namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftPickupTimeRange
    {
        [JsonProperty("timestamp_ms")]
        public long TimestampMilliseconds { get; set; }

        [JsonProperty("range_ms")]
        public int? RangeMilliseconds { get; set; }
    }
}