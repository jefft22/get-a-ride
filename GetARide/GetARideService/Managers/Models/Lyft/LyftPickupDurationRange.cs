namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftPickupDurationRange
    {
        [JsonProperty("duration_ms")]
        public int DurationMilliseconds { get; set; }

        [JsonProperty("range_ms")]
        public int? RangeMilliseconds { get; set; }
    }
}