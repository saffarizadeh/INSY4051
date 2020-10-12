using System;

namespace MyApplication
{
    class Program
    {
static void Main(string[] args)
{
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum from 1 to 10 is " + sum);

            sum = 0;
            for (int i = 20; i <= 30; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum from 20 to 30 is " + sum);

            sum = 0;
            for (int i = 35; i <= 45; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum from 35 to 45 is " + sum);
        }

    }
}
