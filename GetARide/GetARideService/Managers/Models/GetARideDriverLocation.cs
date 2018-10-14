namespace GetARideService.Managers.Models
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class GetARideDriverLocation
    {
        [JsonProperty("bearing")]
        public int Bearing { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }
}