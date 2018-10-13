namespace GetARideService.Managers.Models.Lyft
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class LyftRideEstimatesResponse
    {
        [JsonProperty("cost_estimates")]
        public List<LyftCostEstimates> CostEstimates {get;set;}
    }
}