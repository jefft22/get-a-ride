namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestProvidedLocation
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}