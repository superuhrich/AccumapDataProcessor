using System;
using System.Collections.Generic;
using System.Linq;
using AccumapDataProcessor.DapperModels;
using AccumapDataProcessor.Models;
using BAMCIS;
using BAMCIS.GIS;
using Microsoft.Extensions.Primitives;
using Well = AccumapDataProcessor.DapperModels.Well;

namespace AccumapDataProcessor.Utils; 

public static class GeoUtils {

    private const int DISTANCE_THRESHOLD = 500;

    private const int BEARING_DIFFERENCE_THRESHOLD = 90;

    private const int OFFSET_DISTANCE_CALCULATION_THRESHOLD = 4000;

    private const int WELL_LENGTH_THRESHOLD = 100;

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
                        switch (originSurCoordinate.Equals(offsetSurCoordinate), bearingDelta > BEARING_DIFFERENCE_THRESHOLD) {
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
                            // This case is when two wells are separated but go in roughly the same direction, so we need to check distances apart
                            case (false, true):
                                // Since we dont have directional information of the wells,  we can just make an assumption of a straight well path, from surface to bottomhole, and take iterative distance between those and check if any points on the offset well are within the threshold for it.
                                // Find the well length
                                var wellLength = originSurCoordinate.DistanceTo(originBhCoordinate, DistanceType.METERS);
                                if (wellLength < WELL_LENGTH_THRESHOLD) {
                                    
                                }
                            
                                
                        }





                        // if this is more than the distance threshold, pass it
                        if (interwellSpacing > DISTANCE_THRESHOLD) continue;
                        
                        // When we have two wells that are within the threshold distance, we see the dates to determine parent/child status
                        if ((wellList[i].XOnprodDate - offset.XOnprodDate) > span2) {
                            wellList[i].PcInteractionStatus = InteractionStatus.Child;
                            continue;
                        }

                        wellList[i].PcInteractionStatus = InteractionStatus.Parent;


                    }
                }
            }
            
        }
    }
    
    
}