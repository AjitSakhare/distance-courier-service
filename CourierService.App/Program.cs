using CourierService.App.Models;
using CourierService.App.Services;

namespace CourierService.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the first line of input from console.
            // Example input: "100 3" basedelivery and no. of packegaes.
            string[] firstLine = Console.ReadLine().Split(' ');

            // firstLine[0] = base delivery cost (100)
            // Convert string to double
            double baseCost = double.Parse(firstLine[0]);

            // firstLine[1] = total number of packages (3)
            // Convert string to integer
            int packageCount = int.Parse(firstLine[1]);

            DeliveryCostCalculator costCalculator = new DeliveryCostCalculator();
            OfferService offerService = new OfferService();

            for (int i = 0; i < packageCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Package package = new Package();
                package.Id = input[0];
                package.Weight = double.Parse(input[1]);
                package.Distance = double.Parse(input[2]);
                package.OfferCode = input[3];

                double deliveryCost = costCalculator.Calculate(baseCost, package);
                double discount = offerService.CalculateDiscount(package, deliveryCost);
                double totalCost = deliveryCost - discount;

                Console.WriteLine(package.Id + " " + discount + " " + totalCost);
            }
        }
    }
}
