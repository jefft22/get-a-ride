namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftNearbyDrivers
    {
        [JsonProperty("locations")]
        public List<LyftLocation> Locations { get; set; }
    }
}