namespace GetARideService
{
    using GetARideService.Managers;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.ServiceLocators;

    public sealed class DomainFacade
    {
        private ServiceLocatorBase _serviceLocator;

        private GetARideServiceManager _getARideServiceManager;
        private GetARideServiceManager GetARideServiceManager
        {
            get { return _getARideServiceManager ?? (_getARideServiceManager = _serviceLocator.CreateGetARideServiceManager()); }
        }

        public DomainFacade() : this(new ServiceLocator())
        {
        }

        internal DomainFacade(ServiceLocatorBase serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public GetARideResponse GetRides(GetARideRequest getARideRequest)
        {
            return GetARideServiceManager.GetRides(getARideRequest);
        }
    }
}