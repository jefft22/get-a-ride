namespace GetARideService.Managers.ServiceLocators
{
    using GetARideService.Managers;
    using GetARideService.Managers.Gateways;

    internal sealed class ServiceLocator : ServiceLocatorBase
    {
        protected override GetARideRidesManager CreateGetARideServiceManagerCore()
        {
            return new GetARideRidesManager(this);
        }

        protected override GetARideBaseGateway CreateGetARideGatewayCore()
        {
            return new GetARideLyftGateway();
        }
    }
}