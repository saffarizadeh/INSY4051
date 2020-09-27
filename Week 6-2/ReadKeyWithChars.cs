using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can enter A to go left, D to go right");
            Console.WriteLine("W to go up, and S to go down");
            Console.WriteLine("You can enter 0 to quit the program.");

            bool done = false;
            while (!done)
            {
                string enteredKey = Convert.ToChar(Console.Read()).ToString().ToUpper();
                switch (enteredKey)
                {
                    case "A":
                        Console.WriteLine("<--");
                        break;
                    case "D":
                        Console.WriteLine("-->");
                        break;
                    case "W":
                        Console.WriteLine("^");
                        break;
                    case "S":
                        Console.WriteLine("_");
                        break;
                    case "0":
                        done = true;
                        break;
                }
            }

        }

    }
}
