using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            // Example 1
            Console.Write("Please enter an integer number: ");

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error");
            }


            // Example 2
            Console.Write("Please enter an integer number: ");
            string userInput = "";
            try
            {
                userInput = Console.ReadLine();
                number = Convert.ToInt32(userInput);
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error. Here is the error message:");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Your input was: " + userInput);
            }

            // Example 3
            int number1 = 3000;
            int number2 = 0;
            try
            {
                int y = number1 / number2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", number1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Generic Exception Handler: {0}", e);
            }
        }

    }
}
