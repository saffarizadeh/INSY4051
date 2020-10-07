using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = new List<string>();
            parts.Add("Door");
            parts.Add("Window");

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine();

            parts.Insert(1, "Engine");

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
