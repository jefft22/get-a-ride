namespace GetARideService.Managers.Gateways
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.Models.Mapquest;

    internal sealed class GeocodeMapquestGateway : GeocodeBaseGateway
    {
        public GeocodeMapquestGateway(GatewayConfiguration gatewayConfiguration) : base(gatewayConfiguration)
        {
        }

        protected override async Task GetGeocodeFromAddressCore(GetARideRequest getARideRequest)
        {
            using (var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
                _gatewayConfiguration.ApiUrl + "/address?key=" + _gatewayConfiguration.ClientId +  "&location=" + getARideRequest.FromAddress))
            {
                var result = await _httpClient.SendAsync(httpRequestMessage);
                // Ensure success
                var content = await result.Content.ReadAsStringAsync();
                var mapquestResponse = JsonConvert.DeserializeObject<MapquestGeocodeResponse>(content);

                getARideRequest.From.Latitude = mapquestResponse.Results[0].Locations[0].LatitudeLongitude.Latitude;
                getARideRequest.From.Longitude = mapquestResponse.Results[0].Locations[0].LatitudeLongitude.Longitude;
            }

            using (var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
                _gatewayConfiguration.ApiUrl + "/address?key=" + _gatewayConfiguration.ClientId + "&location=" + getARideRequest.ToAddress))
            {
                var result = await _httpClient.SendAsync(httpRequestMessage);
                // Ensure success
                var content = await result.Content.ReadAsStringAsync();
                var mapquestResponse = JsonConvert.DeserializeObject<MapquestGeocodeResponse>(content);

                getARideRequest.To.Latitude = mapquestResponse.Results[0].Locations[0].LatitudeLongitude.Latitude;
                getARideRequest.To.Longitude = mapquestResponse.Results[0].Locations[0].LatitudeLongitude.Longitude;
            }
        }
    }
}