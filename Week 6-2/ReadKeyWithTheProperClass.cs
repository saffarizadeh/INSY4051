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
                ConsoleKeyInfo enteredKey = Console.ReadKey();
                switch (enteredKey.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("<--");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("-->");
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("^");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("_");
                        break;
                    case ConsoleKey.D0:
                        done = true;
                        break;
                }
            }
        }

    }
}
