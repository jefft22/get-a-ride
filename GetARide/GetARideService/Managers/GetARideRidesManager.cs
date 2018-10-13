namespace GetARideService.Managers
{
    using System.Threading.Tasks;
    using GetARideService.Managers.Gateways;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.ServiceLocators;

    internal sealed class GetARideRidesManager
    {
        private ServiceLocatorBase _serviceLocator;

        private GetARideBaseGateway _getARideGateway;

        private GetARideBaseGateway GetARideGateway { get { return _getARideGateway ?? (_getARideGateway = _serviceLocator.CreateGetARideGateway()); } }

        public GetARideRidesManager(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public async Task<GetARideResponse> GetRides(GetARideRequest getARideRequest)
        {
            return await GetARideGateway.GetRides(getARideRequest);
        }
    }
}