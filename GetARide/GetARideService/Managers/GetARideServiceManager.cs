namespace GetARideService.Managers
{
    using GetARideService.Managers.Models;
    using GetARideService.Managers.ServiceLocators;

    internal sealed class GetARideServiceManager
    {
        private ServiceLocatorBase _serviceLocator;

        public GetARideServiceManager(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public GetARideResponse GetRides(GetARideRequest getARideRequest)
        {
            return null;
        }
    }
}