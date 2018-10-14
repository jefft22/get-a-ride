namespace GetARideService.Managers.Models
{
    internal sealed class GatewayConfiguration
    {
        public string AuthenticationUrl { get; set; }
        public string ApiUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}