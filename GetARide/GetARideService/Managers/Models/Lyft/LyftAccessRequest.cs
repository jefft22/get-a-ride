namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftAccessRequest
    {
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}