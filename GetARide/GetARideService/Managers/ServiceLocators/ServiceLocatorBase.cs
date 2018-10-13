namespace GetARideService.Managers.ServiceLocators
{
    using GetARideService.Managers;
    using GetARideService.Managers.Gateways;

    internal abstract class ServiceLocatorBase
    {
        public GetARideRidesManager CreateGetARideServiceManager()
        {
            return CreateGetARideServiceManagerCore();
        }

        public GetARideBaseGateway CreateGetARideGateway()
        {
            return CreateGetARideGatewayCore();
        }

        protected abstract GetARideRidesManager CreateGetARideServiceManagerCore();

        protected abstract GetARideBaseGateway CreateGetARideGatewayCore();
    }
}