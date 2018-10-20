namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestOptions
    {
        [JsonProperty("maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty("thumbMaps")]
        public bool ThumbMaps { get; set; }

        [JsonProperty("ignoreLatLngInput")]
        public bool IgnoreLatitudeLongitudeInput { get; set; }
    }
}