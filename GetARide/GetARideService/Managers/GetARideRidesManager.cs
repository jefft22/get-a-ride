namespace GetARideService.Managers
{
    using System.Threading.Tasks;
    using GetARideService.Managers.ConfigurationProviders;
    using GetARideService.Managers.Gateways;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.ServiceLocators;

    internal sealed class GetARideRidesManager
    {
        private ServiceLocatorBase _serviceLocator;

        private ConfigurationProviderBase _configurationProvider;
        private GetARideBaseGateway _getARideGateway;

        private ConfigurationProviderBase ConfigurationProvider
        {
            get
            {
                return _configurationProvider ??
                    (_configurationProvider = _serviceLocator.CreateConfigurationProvider());
            }
        }

        private GetARideBaseGateway GetARideLyftGateway
        {
            get
            {
                return _getARideGateway ?? 
                    (_getARideGateway = _serviceLocator.CreateGetARideGateway(ConfigurationProvider.GetLyftGatewayConfiguration().GetAwaiter().GetResult()));
            }
        }

        public GetARideRidesManager(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public async Task<GetARideResponse> GetRides(GetARideRequest getARideRequest)
        {
            return await GetARideLyftGateway.GetRides(getARideRequest);
        }
    }
}