namespace GetARideService.Managers.ServiceLocators
{
    using GetARideService.Managers;
    using GetARideService.Managers.ConfigurationProviders;
    using GetARideService.Managers.Gateways;
    using GetARideService.Managers.Models;

    internal sealed class ServiceLocator : ServiceLocatorBase
    {
        protected override GetARideRidesManager CreateGetARideServiceManagerCore()
        {
            return new GetARideRidesManager(this);
        }

        protected override GetARideBaseGateway CreateGetARideGatewayCore(GatewayConfiguration gatewayConfiguration)
        {
            return new GetARideLyftGateway(gatewayConfiguration);
        }

        protected override ConfigurationProviderBase CreateConfigurationProviderCore()
        {
            return new ConfigurationProvider();
        }
    }
}