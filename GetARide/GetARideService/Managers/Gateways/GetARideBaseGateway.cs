namespace GetARideService.Managers.Gateways
{
    using GetARideService.Managers.Models;

    internal abstract class GetARideBaseGateway
    {
        public GetARideResponse GetRides(GetARideRequest getARideRequest)
        {
            return GetRidesCore(getARideRequest);
        }

        abstract protected GetARideResponse GetRidesCore(GetARideRequest getARideRequest);
    }
}