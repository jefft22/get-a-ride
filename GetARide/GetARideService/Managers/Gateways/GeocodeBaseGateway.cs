namespace GetARideService.Managers.Gateways
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using GetARideService.Managers.Models;

    internal abstract class GeocodeBaseGateway
    {
        protected HttpClient _httpClient;
        protected GatewayConfiguration _gatewayConfiguration;

        protected GeocodeBaseGateway(GatewayConfiguration gatewayConfiguration)
        {
            _httpClient = new HttpClient();
            _gatewayConfiguration = gatewayConfiguration;
        }

        public async Task GetGeocodeFromAddress(GetARideRequest getARideRequest)
        {
            await GetGeocodeFromAddressCore(getARideRequest);
        }

        abstract protected Task GetGeocodeFromAddressCore(GetARideRequest getARideRequest);
    }
}