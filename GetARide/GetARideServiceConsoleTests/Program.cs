namespace GetARideServiceConsoleTests
{
    using System;
    using GetARideService.Managers.Models;
    using Newtonsoft.Json;

    public sealed class Program
    {
        static void Main(string[] args)
        {
            var domain = new GetARideService.DomainFacade();
            Console.WriteLine("Created GetARide service.");

            var rideRequest = new GetARideRequest()
            {
                AccessToken = string.Empty,
                AccessTokenExpirationMilliseconds = 0,
                From = new GetARideLocation()
                {
                    Latitude = 37.7763,
                    Longitude = -122.3918
                },
                To = new GetARideLocation()
                {
                    Latitude = 37.8763,
                    Longitude = -122.3928
                }
            };

            Console.WriteLine("Trying to get rides...");
            var rides = domain.GetRides(rideRequest).GetAwaiter().GetResult();

            Console.WriteLine("Got rides. Displaying...");
            Console.WriteLine(JsonConvert.SerializeObject(rides));

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}