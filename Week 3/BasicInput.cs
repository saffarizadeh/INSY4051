using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /////////// Slide 15 ///////////

            double hourlyRateOfService = 5.25;
            int numberOfHours;

            Console.WriteLine("Please enter the number of hours of service you need this year:");
            string userInput = Console.ReadLine();
            numberOfHours = Convert.ToInt32(userInput);
            double totalPrice = numberOfHours * hourlyRateOfService;
            Console.WriteLine();
            Console.WriteLine("The hourly rate for this service is $" + hourlyRateOfService);
            Console.WriteLine("You need " + numberOfHours + " hours");
            Console.WriteLine("The total price is $" + totalPrice);
            Console.WriteLine("You can set up a monthly payment ($" + totalPrice / 12 + " per month)");
            Console.WriteLine();
            Console.WriteLine("Press Enter to close the application... ");
            Console.ReadLine();

        }
    }
}
