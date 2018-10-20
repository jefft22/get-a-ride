namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestGeocodeResponse
    {
        [JsonProperty("info")]
        public MapquestInfo Info { get; set; }

        [JsonProperty("options")]
        public MapquestOptions Options { get; set; }

        [JsonProperty("results")]
        public List<MapquestResult> Results { get; set; }
    }
}