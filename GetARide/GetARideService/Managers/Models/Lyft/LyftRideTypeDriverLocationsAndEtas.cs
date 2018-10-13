namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftRideTypeDriverLocationsAndEtas
    {
        [JsonProperty("pickup_duration_range")]
        public LyftPickupDurationRange PickupDurationRange { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("ride_type")]
        public string RideType { get; set; }

        [JsonProperty("nearby_drivers")]
        public List<LyftNearbyDrivers> NearbyDrivers { get; set; }

        [JsonProperty("pickup_time_range")]
        public LyftPickupTimeRange PickupTimeRange { get; set; }
    }
}