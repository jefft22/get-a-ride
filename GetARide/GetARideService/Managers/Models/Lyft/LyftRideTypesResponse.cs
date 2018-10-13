namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftRideTypesResponse
    {
        [JsonProperty("ride_types")]
        public List<LyftRideType> RideTypes { get; set; }
    }
}