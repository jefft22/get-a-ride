namespace GetARideService.Managers.ServiceLocators
{
    using GetARideService.Managers;

    internal sealed class ServiceLocator : ServiceLocatorBase
    {
        protected override GetARideServiceManager GetARideServiceManagerCore()
        {
            return new GetARideServiceManager(this);
        }
    }
}