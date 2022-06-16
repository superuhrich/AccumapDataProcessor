using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using AccumapDataProcessor.DapperModels;
using AccumapDataProcessor.Models;
using BAMCIS;
using BAMCIS.GIS;
using Microsoft.Extensions.Primitives;
using Microsoft.Identity.Client;
using Well = AccumapDataProcessor.DapperModels.Well;

namespace AccumapDataProcessor.Utils; 

public static class GeoUtils {

    private const int DISTANCE_THRESHOLD = 500;

    private const int BEARING_DIFFERENCE_THRESHOLD = 90;

    private const int OFFSET_DISTANCE_CALCULATION_THRESHOLD = 4000;

    private const int WELL_LENGTH_THRESHOLD = 50;

    private const int WELL_PATH_SEGMENT_MAX_SIZE = 100;

    /// <summary>
    /// Calculates the absolute difference in bearing delta between two different wells. 
    /// </summary>
    /// <param name="wellBearing"></param>
    /// <param name="offsetBearing"></param>
    /// <returns></returns>
    private static double BearingDifference(double wellBearing, double offsetBearing) {
        var bearingDifference = Math.Abs(wellBearing - offsetBearing);
        if (bearingDifference < 180) return bearingDifference;
        return 360 - bearingDifference;
    }


    private static List<GeoCoordinate> GetWellLateralCoordinates(GeoCoordinate surfaceLocation,
        GeoCoordinate bhLocation, double bearing) {
        // We need to figure out the length of the well, and cut it into segments to analyze possible distance to offsets. 
        var wellLength = surfaceLocation.DistanceTo(bhLocation, DistanceType.METERS);
        // Figure out how many segments we are going to cut it into. 
        var segmentCount = wellLength / WELL_PATH_SEGMENT_MAX_SIZE;
        // Then figure out the size of each segment
        var segmentLength = Math.Ceiling(wellLength / segmentCount);
        // The list of segments
        var segmentCoordinates = new List<GeoCoordinate>();
     
        // Then add the internal distances
        for (var i = 0; i < segmentCount; i++) {
            var interLocation = (surfaceLocation.FindDestination(bearing, segmentLength * i, DistanceType.METERS));
            var coordinate = new GeoCoordinate(interLocation.GetLatitude(), interLocation.GetLongitude());
            segmentCoordinates.Add(coordinate);
        }
        
        // Add the bottomhole location
        segmentCoordinates.Add(bhLocation);

        return segmentCoordinates;

    }

    private static bool IsWellInOffsetDistance(List<GeoCoordinate> originWellCoordinates,
        List<GeoCoordinate> offsetWellCoordinates) {
        // We need to iterate through the nodes on each well, to see if any point of them is close enough to the other. 
        foreach (var originNode in originWellCoordinates) {
            foreach (var offsetNode in offsetWellCoordinates) {
                if (originNode.DistanceTo(offsetNode, DistanceType.METERS) < DISTANCE_THRESHOLD)  return true;
            }
        }
        return false;
    }

    private static bool IsSameLocation(GeoCoordinate firstLocation, GeoCoordinate secondLocation) {
        return  (Math.Abs((firstLocation.Latitude.DecimalDegrees - secondLocation.Latitude.DecimalDegrees)) < 0.000001 &&
                (Math.Abs((firstLocation.Longitude.DecimalDegrees - secondLocation.Longitude.DecimalDegrees)) < 0.000001));
    }

    private static bool IsOffsetWellDivergent(List<GeoCoordinate> originWellCoordinates,
        List<GeoCoordinate> offsetWellCoordinates) {
            // Here we are just checking that at a point roughtly 100m from the sufrace location in the same bearing as the well, is further away from the surface indicating that they are diverging 
            // If the distance from the first node on origin and offset are further than the distance from origin and offset surface locations,  we can assume they are diverging
            if (originWellCoordinates[1].DistanceTo(offsetWellCoordinates[1], DistanceType.METERS) >
                originWellCoordinates[0].DistanceTo(offsetWellCoordinates[0], DistanceType.METERS)) return true;
            return false;

    }
    
    

    public static void DetermineParentChildStatus(IList<Well> wellList) {

        TimeSpan span2 = new TimeSpan(365, 0, 0, 0);
        // Go through each well...
        for (var i = 0; i < wellList.Count; i++) {
            
            // Make sure we have lat and long for the well we are looking at
            if (wellList[i].BottomHoleLatitude != null && wellList[i].BottomHoleLongitude != null && wellList[i].SurfaceLatitude != null && wellList[i].SurfaceLongitude != null) {
                //Get a coordinate for the well we are analysing
                var originBhCoordinate = new GeoCoordinate((double)wellList[i].BottomHoleLatitude, (double)wellList[i].BottomHoleLongitude);
                var originSurCoordinate = new GeoCoordinate((double)wellList[i].SurfaceLatitude,
                    (double)wellList[i].SurfaceLongitude);
                // Get the well bearing 
                var originWellBearing = originSurCoordinate.InitialBearingTo(originBhCoordinate);
                // Get the lateral coordinates
                var originLateralCoordinates =
                    GetWellLateralCoordinates(originSurCoordinate, originBhCoordinate, originWellBearing);

                foreach (var offset in wellList) {
                    // Make sure we have a lat and long for each of these as well
                    if (offset.BottomHoleLatitude != null && offset.BottomHoleLongitude != null && offset.SurfaceLatitude != null && offset.SurfaceLongitude!= null) {
                        //Make a coordinate for the offset
                        var offsetBhCoordingate = new GeoCoordinate((double)offset.BottomHoleLatitude,
                            (double)offset.BottomHoleLongitude);
                        var offsetSurCoordinate = new GeoCoordinate((double)offset.SurfaceLatitude,
                            (double)offset.SurfaceLongitude);
                      
                        
                        
                        // Get the offset Bearing
                        var offsetWellBearing = offsetSurCoordinate.InitialBearingTo(offsetBhCoordingate);
                        
                        //Determine the distance between them and add them to a list
                        var offsetDistanceList = new List<double>();

                        offsetDistanceList.Add( originBhCoordinate.DistanceTo(offsetBhCoordingate, DistanceType.METERS));
                        offsetDistanceList.Add(originSurCoordinate.DistanceTo(offsetBhCoordingate, DistanceType.METERS));
                        offsetDistanceList.Add(originBhCoordinate.DistanceTo(offsetSurCoordinate,  DistanceType.METERS));
                        offsetDistanceList.Add(originSurCoordinate.DistanceTo(offsetSurCoordinate, DistanceType.METERS));
                        
                        // Find the minimum of all the distances, since we dont really have offset envelopes with Accumap Data
                        var interwellSpacing = offsetDistanceList.Min();
                        
                        // Check and see if the offset is even in the same neighbourhood,  if not dont even bother doing the calculations
                        if(interwellSpacing > OFFSET_DISTANCE_CALCULATION_THRESHOLD ) continue;

                        var bearingDelta = BearingDifference(originWellBearing, offsetWellBearing);
                        
                        // If it is in the same neighbourhood,  then we can go into our more detailed check. 
                        // The two main cases are if two wells share a surface or not...
                        switch (IsSameLocation(originSurCoordinate, offsetSurCoordinate), bearingDelta > BEARING_DIFFERENCE_THRESHOLD) {
                            // This case is when two wells are from the same surface, but do not go in the same direction, thus cannot cause parent/child interactions
                            case (true, true):
                                // Since the default is parent anyways, we do nothing here
                                break;
                            // This case is when two wells are from the same surface, and go in the same direction, so there is possibility for interaction
                            case (true, false):
                                // We need to check the dates to see if there would be competative drainage
                                if ((wellList[i].XOnprodDate - offset.XOnprodDate) > span2) {
                                    wellList[i].PcInteractionStatus = InteractionStatus.Child;
                                    
                                }
                                break;
                            // The case when two surfaces are separated but go in roughly the same direction, so we need to check distances apart
                            case (false, false): {
                                // Since we dont have directional information of the wells,  we can just make an assumption of a straight well path, from surface to bottomhole, and take iterative distance between those and check if any points on the offset well are within the threshold for it.
                                // Get the well path for the offset well
                                var offsetLateralCoordinates = GetWellLateralCoordinates(offsetSurCoordinate,
                                    offsetBhCoordingate, offsetWellBearing);
                                // Compare it to the origin well
                                var isPossibleInteraction =
                                    IsWellInOffsetDistance(originLateralCoordinates, offsetLateralCoordinates);
                                // ...and if there is check the dates to see if there would be competative drainage
                                if (((wellList[i].XOnprodDate - offset.XOnprodDate) > span2) && isPossibleInteraction) {
                                    wellList[i].PcInteractionStatus = InteractionStatus.Child;
                                }
                                break;
                            }
                                
                            // The case when two surfaces are separated, but go in opposite direction,  we can check to see if they are angled away from each other, in which case there would be no interaction. 
                            case (false, true): {
                                // We need teh well path for the offset well again
                                var offsetLateralCoordinates = GetWellLateralCoordinates(offsetSurCoordinate,
                                    offsetBhCoordingate, offsetWellBearing);
                                // We need to see if there is possible interaction
                                var isPossibleInteraction =
                                    IsWellInOffsetDistance(originLateralCoordinates, offsetLateralCoordinates);
                                // If there is, then we need to determine if the wells work away from each other, and the case is that the surfaces are just nearby
                                var isOffsetWellDiverging =
                                    IsOffsetWellDivergent(originLateralCoordinates, offsetLateralCoordinates);
                                // ...and depending on the above,  we can then check the dates to see if we would have competative drainage
                                if (((wellList[i].XOnprodDate - offset.XOnprodDate) > span2) && isPossibleInteraction &&
                                    !isOffsetWellDiverging) {
                                    wellList[i].PcInteractionStatus = InteractionStatus.Child;
                                }

                                break;

                            }
                                
                                
                            
                        }
                    }
                }
            }
            
        }
    }
    
    
}