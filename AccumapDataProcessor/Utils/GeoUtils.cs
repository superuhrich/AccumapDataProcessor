using System;
using System.Collections.Generic;
using System.Linq;
using AccumapDataProcessor.DapperModels;
using AccumapDataProcessor.Models;
using Geolocation;
using Well = AccumapDataProcessor.DapperModels.Well;

namespace AccumapDataProcessor.Utils; 

public static class GeoUtils {

    private const int MILES_TO_METERS = 1600;

    private const int DISTANCE_THRESHOLD = 500;
    
    

    public static void DetermineParentChildStatus(IList<Well> wellList) {

        TimeSpan span2 = new TimeSpan(365, 0, 0, 0);
        // Go through each well...
        for (var i = 0; i < wellList.Count; i++) {
            
            // Make sure we have lat and long for the well we are looking at
            if (wellList[i].BottomHoleLatitude != null && wellList[i].BottomHoleLongitude != null && wellList[i].SurfaceLatitude != null && wellList[i].SurfaceLongitude != null) {
                //Get a coordinate for the well we are analysing
                var originBhCoordinate = new Coordinate((double)wellList[i].BottomHoleLatitude, (double)wellList[i].BottomHoleLongitude);
                var originSurCoordinate = new Coordinate((double)wellList[i].SurfaceLatitude,
                    (double)wellList[i].SurfaceLongitude);

                foreach (var offset in wellList) {
                    // Make sure we have a lat and long for each of these as well
                    if (offset.BottomHoleLatitude != null && offset.BottomHoleLongitude != null && offset.SurfaceLatitude != null && offset.SurfaceLongitude!= null) {
                        //Make a coordinate for the offset
                        var offsetBhCoordingate = new Coordinate((double)offset.BottomHoleLatitude,
                            (double)offset.BottomHoleLongitude);
                        var offsetSurCoordinate = new Coordinate((double)offset.SurfaceLatitude,
                            (double)offset.SurfaceLongitude);
                        
                        //Determine the distance between them and add them to a list
                        var offsetDistanceList = new List<double>();

                        offsetDistanceList.Add(GeoCalculator.GetDistance(originBhCoordinate, offsetBhCoordingate));
                        offsetDistanceList.Add(GeoCalculator.GetDistance(originSurCoordinate, offsetBhCoordingate));
                        offsetDistanceList.Add(GeoCalculator.GetDistance(originBhCoordinate, offsetSurCoordinate));
                        offsetDistanceList.Add(GeoCalculator.GetDistance(originSurCoordinate, offsetSurCoordinate));
                        
                        // Find the minimum of all the distances, since we dont really have offset envelopes with Accumap Data
                        var interwellSpacing = offsetDistanceList.Min();
                        
                        
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