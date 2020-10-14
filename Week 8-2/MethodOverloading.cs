using System;

namespace MyApplication
{
    class Program
    {
		public static void Main(String[] args)
		{
			// Invoke the Max method with int parameters
			Console.WriteLine("The maximum of 3 and 4 is " + Max(3, 4));
			// Invoke the max method with the double parameters
			Console.WriteLine("The maximum of 3.0 and 5.4 is " + Max(3.0, 5.4));
			// Invoke the max method with three double parameters
			Console.WriteLine("The maximum of 3.0, 5.4, and 10.14 is " + Max(3.0, 5.4, 10.14));
		}
		/** Return the max of two int values */
		public static int Max(int num1, int num2)
		{
			if (num1 > num2) // We can write the statement without braces when we have only one statement
				return num1;
			else
				return num2;
		}
		/** Find the max of two double values */
		public static double Max(double num1, double num2)
		{
			if (num1 > num2)
				return num1;
			else
				return num2;
		}
		/** Return the max of three double values */
		public static double Max(double num1, double num2, double num3)
		{
			return Max(Max(num1, num2), num3);
		}
	}
}
