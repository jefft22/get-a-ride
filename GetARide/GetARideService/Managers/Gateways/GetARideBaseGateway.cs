namespace GetARideService.Managers.Gateways
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using GetARideService.Managers.Models;

    internal abstract class GetARideBaseGateway
    {
        protected HttpClient _httpClient;

        protected GetARideBaseGateway()
        {
            _httpClient = new HttpClient();
        }

        public async Task<GetARideResponse> GetRides(GetARideRequest getARideRequest)
        {
            return await GetRidesCore(getARideRequest);
        }

        abstract protected Task<GetARideResponse> GetRidesCore(GetARideRequest getARideRequest);
    }
}