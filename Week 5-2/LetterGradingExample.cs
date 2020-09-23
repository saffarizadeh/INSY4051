using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'A';

            switch (grade)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("Great job!");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("Good effort.");
                    break;
                default:
                    Console.WriteLine("Do not give up!");
                    break;
            }
        }
    }
}
