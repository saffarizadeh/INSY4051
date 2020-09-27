using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the table heading
            Console.WriteLine("{0,31}", "Multiplication Table");

            // Display the number title
            Console.Write("{0,4}", "");
            for (int j = 1; j <= 9; j++)
                Console.Write("{0,4}", j);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            // Print table body
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i + " | ");
                for (int j = 1; j <= 9; j++)
                {
                    // Display the product and align properly
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }
        }

    }
}
