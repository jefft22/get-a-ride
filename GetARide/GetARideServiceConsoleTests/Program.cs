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
                FromAddress = "2234 Mission St, San Francisco, CA 94110",
                ToAddress = "1701 Stockton St, San Francisco, CA 94133",
                From = new GetARideLocation()
                {
                    Latitude = 0, //37.7763,
                    Longitude = 0 //-122.3918
                },
                To = new GetARideLocation()
                {
                    Latitude = 0, //37.8763,
                    Longitude = 0 //-122.3928
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