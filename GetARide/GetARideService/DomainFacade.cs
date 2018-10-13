namespace GetARideService
{
    using System.Threading.Tasks;
    using GetARideService.Managers;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.ServiceLocators;

    public sealed class DomainFacade
    {
        private ServiceLocatorBase _serviceLocator;

        private GetARideRidesManager _getARideServiceManager;
        private GetARideRidesManager GetARideServiceManager
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

        public async Task<GetARideResponse> GetRides(GetARideRequest getARideRequest)
        {
            return await GetARideServiceManager.GetRides(getARideRequest);
        }
    }
}