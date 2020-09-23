using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-else example
            int status = 1;
            if (status == 0)
            {
                // compute taxes for single filers;
            }
            else if (status == 1)
            {
                // compute taxes for married filed jointly;
            }
            else if (status == 2)
            {
                // compute taxes for married filed separately;
            }
            else if (status == 3)
            {
                // compute taxes for head of household;
            }
            else
            {
                Console.WriteLine("Errors: invalid status");
            }

            //switch example
            status = 1;
            switch (status)
            {
                case 1:
                    // compute taxes for single filers;
                    break;
                case 2:
                    // compute taxes for married filed jointly;
                    break;
                case 3:
                    // compute taxes for married filed separately;
                    break;
                case 4:
                    // compute taxes for head of household;
                    break;
                default:
                    Console.WriteLine("Errors: invalid status");
                    break;
            }
        }
    }
}
