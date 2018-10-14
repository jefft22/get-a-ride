namespace GetARideService.Managers.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class GetARideRideDetails
    {
        [JsonProperty("deep_app_link")]
        public string DeepAppLink { get; set; }

        [JsonProperty("ride_type")]
        public string RideType { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimated_cost")]
        public string EstimatedCost { get; set; }

        [JsonProperty("estimated_time_of_arrival")]
        public string EstimatedTimeOfArrival { get; set; }

        [JsonProperty("driver_location")]
        public List<GetARideDriverLocation> DriverLocation { get; set; }
    }
}