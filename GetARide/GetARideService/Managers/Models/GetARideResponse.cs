namespace GetARideService.Managers.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class GetARideResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("access_token_expiration_ms")]
        public long AccessTokenExpirationMilliseconds { get; set; }

        [JsonProperty("ride_details")]
        public List<GetARideRideDetails> RideDetails { get; set; }

        [JsonProperty("service_status")]
        public string ServiceStatus { get; set; }

        [JsonProperty("service_status_message")]
        public string ServiceStatusMessage { get; set; }
    }
}