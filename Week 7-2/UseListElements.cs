using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(50);
            numbers.Add(20);
            numbers.Add(10);
            numbers.Add(70);

            int x = numbers[0] + numbers[2];
            Console.WriteLine(x);

            numbers[0] = 100;
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
