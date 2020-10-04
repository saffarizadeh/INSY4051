using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of grades you wish to store: ");
            int numOfGrades = Convert.ToInt32(Console.ReadLine());
            double[] grades = new double[numOfGrades];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade {0}: ", i + 1);
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            Console.WriteLine();
            Console.WriteLine("The average is {0}.", sum / grades.Length);
        }
    }
}
