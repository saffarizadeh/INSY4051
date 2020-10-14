using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        // Fine with no errors
        public static void CorrectMethod()
        {
            int x = 1;
            int y = 1;
            // i is declared 
            for (int i = 1; i < 10; i++)
            {
                x += i;
            }
            // i is declared again
            for (int i = 1; i < 10; i++)
            {
                y += i;
            }
        }

        // With errors
        public static void IncorrectMethod()
        {
            int x = 1;
            int y = 1;
            for (int i = 1; i < 10; i++)
            {
                int x = 0;
                x += i;
            }
        }
    }
}

