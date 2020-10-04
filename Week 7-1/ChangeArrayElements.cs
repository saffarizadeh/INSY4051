using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars1 = new string[4];
            cars1[0] = "Volvo";
            cars1[1] = "BMW";
            cars1[2] = "Ford";
            cars1[3] = "Mazda";
            Console.WriteLine(cars1[0]);
            // Output is Volvo

            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            cars2[0] = "Opel";
            Console.WriteLine(cars2[0]);
            // Now outputs Opel instead of Volvo

        }
    }
}
