namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestResult
    {
        [JsonProperty("providedLocation")]
        public MapquestProvidedLocation ProvidedLocation { get; set; }

        [JsonProperty("locations")]
        public List<MapquestLocation> Locations { get; set; }
    }
}