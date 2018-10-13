namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftAccessResponse
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}