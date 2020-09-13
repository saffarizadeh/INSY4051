using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = String.Format("It is now {0:d} at {0:t}",
                                     DateTime.Now);

            Console.WriteLine(s);
            // Output similar to: 'It is now 9/14/2020 at 02:20 PM'

        }
    }
}
