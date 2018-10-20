namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestInfo
    {
        [JsonProperty("statuscode")]
        public int StatusCode { get; set; }

        [JsonProperty("copyright")]
        public MapquestCopyright Copyright { get; set; }

        [JsonProperty("messages")]
        public List<string> Messages { get; set; }
    }
}