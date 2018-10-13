namespace GetARideServiceConsoleTests
{
    using System;
    using GetARideService.Managers.Models;

    public sealed class Program
    {
        static void Main(string[] args)
        {
            var domain = new GetARideService.DomainFacade();
            Console.WriteLine("Created GetARide service.");

            Console.WriteLine("Trying to get rides...");
            domain.GetRides(new GetARideRequest()).GetAwaiter().GetResult();

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
