using System;

namespace MyApplication
{
    class Program
    {
		public static void Main(String[] args)
		{
			// Invoke the Max method with int parameters
			Console.WriteLine("The maximum of 1 and 2 is " + Max(1, 2));
		}
		public static double Max(int num1, double num2)
		{
			if (num1 > num2)
				return num1;
			else
				return num2;
		}
		public static double Max(double num1, int num2)
		{
			if (num1 > num2)
				return num1;
			else
				return num2;
		}
	}
}
