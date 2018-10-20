namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestCopyright
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("imageAltText")]
        public string ImageAltText { get; set; }
    }
}