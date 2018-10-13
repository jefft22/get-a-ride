namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftCostEstimates
    {
        [JsonProperty("ride_type")]
        public string RideType { get; set; }

        [JsonProperty("estimated_duration_seconds")]
        public long EstimatedDurationSeconds { get; set; }

        [JsonProperty("estimated_distance_miles")]
        public long EstimatedDistanceMiles { get; set; }

        [JsonProperty("estimated_cost_cents_max")]
        public long EstimatedCostCentsMax { get; set; }

        [JsonProperty("primetime_percentage")]
        public string PrimetimePercentage { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("estimated_cost_cents_min")]
        public long EstimatedCostCentsMin { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("primetime_confirmation_token")]
        public string PrimetimeConfirmationToken { get; set; }

        [JsonProperty("cost_token")]
        public string CostToken { get; set; }

        [JsonProperty("is_valid_estimate")]
        public string IsValidEstimate { get; set; }
    }
}