namespace GetARideService.Managers.Gateways.Mappers
{
    using System;
    using System.Collections.Generic;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.Models.Lyft;

    internal static class LyftMapper
    {
        public static void MapLyftToGetARide(GetARideRequest getARideRequest, GetARideResponse getARideResponse, LyftRideTypesResponse lyftRideTypes, LyftRideEstimatesResponse lyftRideEstimates, LyftNearbyDriversEtasResponse lyftNearbyDriversEtas)
        {
            getARideResponse.RideDetails = new List<GetARideRideDetails>();

            foreach(var rideType in lyftRideTypes.RideTypes)
            {
                var getARideRideDetails = new GetARideRideDetails();
                getARideRideDetails.DeepAppLink = GetDeepAppLink(getARideRequest.From, getARideRequest.To, rideType.RideType);
                getARideRideDetails.RideType = rideType.RideType;
                getARideRideDetails.DisplayName = rideType.DisplayName;
                getARideRideDetails.Description = rideType.Seats + " seats";
                getARideRideDetails.DriverLocation = new List<GetARideDriverLocation>();
                getARideResponse.RideDetails.Add(getARideRideDetails);
            }

            foreach(var rideType in getARideResponse.RideDetails)
            {
                foreach(var estimate in lyftRideEstimates.CostEstimates)
                {
                    if (rideType.RideType == estimate.RideType)
                    {
                        var average = (estimate.EstimatedCostCentsMin + estimate.EstimatedCostCentsMax) / 2;
                        var dollars = Math.Floor(average / 100d);
                        var cents = average % 100d;
                        rideType.EstimatedCost = $"${dollars}.{cents}";
                        break;
                    }
                }
            }

            foreach(var rideType in getARideResponse.RideDetails)
            {
                foreach (var estimate in lyftNearbyDriversEtas.NearbyDriversPickupEtas)
                {
                    if (rideType.RideType == estimate.RideType)
                    {
                        rideType.EstimatedTimeOfArrival = "In " + Math.Floor(estimate.PickupDurationRange.DurationMilliseconds / 60000d) + " min";
                        rideType.DriverLocation = new List<GetARideDriverLocation>();

                        foreach(var driver in estimate.NearbyDrivers)
                        {
                            var getARideDriverLocation = new GetARideDriverLocation();
                            getARideDriverLocation.Bearing = CalculateBearingAngle(driver.Locations);
                            getARideDriverLocation.Latitude = driver.Locations[0].Latitude;
                            getARideDriverLocation.Longitude = driver.Locations[0].Longitude;
                            rideType.DriverLocation.Add(getARideDriverLocation);
                        }
                    }
                }
            }
        }

        private static string GetDeepAppLink(GetARideLocation from, GetARideLocation to, string rideType)
        {
            return $"lyft://ridetype?id={rideType}&pickup[Latitude]={from.Latitude}&pickup[Longitude]={from.Longitude}&" +
                   $"destination[Latitude]={to.Latitude}&destination[Longitude]={to.Longitude}";
        }

        private static int CalculateBearingAngle(IReadOnlyList<LyftLocation> locations)
        {
            if (locations.Count < 2)
            {
                return 0;
            }

            return Convert.ToInt32(CalculateBearingDirection(locations[0], locations[1]));
        }

        private static double CalculateBearingDirection(LyftLocation startLocation, LyftLocation endLocation)
        {
            var dLon = (endLocation.Longitude - startLocation.Longitude);
            var y = Math.Sin(dLon) * Math.Cos(endLocation.Latitude);
            var x = Math.Cos(startLocation.Latitude) * Math.Sin(endLocation.Latitude) - Math.Sin(startLocation.Latitude);
            var bearing = Math.Atan2(y, x);
            bearing = bearing * (180 / Math.PI);
            bearing = (bearing + 360) % 360;

            return bearing;
        }
    }
}