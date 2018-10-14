namespace GetARideService.Managers.Models
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class GetARideRequest
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("access_token_expiration_ms")]
        public long AccessTokenExpirationMilliseconds { get; set; }

        [JsonProperty("from")]
        public GetARideLocation From { get; set; }

        [JsonProperty("to")]
        public GetARideLocation To { get; set; }
    }
}