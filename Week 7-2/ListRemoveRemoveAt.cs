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
            parts.Insert(1, "Engine");

            parts.Remove("Window");

            parts.RemoveAt(0);
        }
    }
}
