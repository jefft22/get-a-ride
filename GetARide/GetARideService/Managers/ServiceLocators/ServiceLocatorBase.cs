namespace GetARideService.Managers.ServiceLocators
{
    using GetARideService.Managers;

    internal abstract class ServiceLocatorBase
    {
        public GetARideServiceManager CreateGetARideServiceManager()
        {
            return GetARideServiceManagerCore();
        }



        protected abstract GetARideServiceManager GetARideServiceManagerCore();
    }
}