using System;

namespace MyApplication
{
    class Program
    {
        public static char GetGrade(double score)
        {
            if (score >= 90.0)
            {
                return 'A';
            }
            else if (score >= 80.0)
            {
                return 'B';
            }
            else if (score >= 70.0)
            {
                return 'C';
            }
            else if (score >= 60.0)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        public static void PrintGrade(double score)
        {
            if (score >= 90.0)
            {
                Console.WriteLine("The grade is A");
            }
            else if (score >= 80.0)
            {
                Console.WriteLine("The grade is B");
            }
            else if (score >= 70.0)
            {
                Console.WriteLine("The grade is C");
            }
            else if (score >= 60.0)
            {
                Console.WriteLine("The grade is D");
            }
            else
            {
                Console.WriteLine("The grade is F");
            }
        }
        static void Main(string[] args)
        {
            // Calling GetGrade, which return char
            Console.WriteLine("The grade is " + GetGrade(78.5));
            Console.WriteLine("The grade is " + GetGrade(59.5));

            // Calling PrintGrade, which return void
            PrintGrade(78.5);
            PrintGrade(59.5);
        }

    }
}
