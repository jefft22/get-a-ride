namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestLatitudeLongitude
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}