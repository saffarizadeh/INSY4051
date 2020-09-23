using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 2");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
