namespace GetARideService.Managers.ServiceLocators
{
    using GetARideService.Managers;
    using GetARideService.Managers.ConfigurationProviders;
    using GetARideService.Managers.Gateways;
    using GetARideService.Managers.Models;

    internal abstract class ServiceLocatorBase
    {
        public GetARideRidesManager CreateGetARideServiceManager()
        {
            return CreateGetARideServiceManagerCore();
        }

        public GetARideBaseGateway CreateGetARideGateway(GatewayConfiguration gatewayConfiguration)
        {
            return CreateGetARideGatewayCore(gatewayConfiguration);
        }

        public GeocodeBaseGateway CreateGeocodeGateway(GatewayConfiguration gatewayConfiguration)
        {
            return CreateGeocodeGatewayCore(gatewayConfiguration);
        }

        public ConfigurationProviderBase CreateConfigurationProvider()
        {
            return CreateConfigurationProviderCore();
        }

        protected abstract GetARideRidesManager CreateGetARideServiceManagerCore();

        protected abstract GetARideBaseGateway CreateGetARideGatewayCore(GatewayConfiguration gatewayConfiguration);

        protected abstract GeocodeBaseGateway CreateGeocodeGatewayCore(GatewayConfiguration gatewayConfiguration);

        protected abstract ConfigurationProviderBase CreateConfigurationProviderCore();
    }
}