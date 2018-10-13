namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftNearbyDriversEtasResponse
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("nearby_drivers_pickup_etas")]
        public List<LyftRideTypeDriverLocationsAndEtas> NearbyDriversPickupEtas { get; set; }
    }
}