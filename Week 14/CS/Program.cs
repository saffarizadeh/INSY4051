using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int x1 = 5;
            double x2 = 3.1415;
            String x3 = "123.45";

            // Type Conversion
            double x4 = x1;
            int x5 = (int)x1;
            double x6 = Double.Parse(x3);
            String x7 = Convert.ToString(x2);
            // OR
            x7 = x2.ToString();


			// Basic I/O
			// Shortcut: type sysout and press Ctrl + space
			Console.WriteLine(x1);
			Console.WriteLine("This is the output: " + x2 + " " + x3);
			Console.Write("Enter something: ");
			String userInput = Console.ReadLine();
			Console.WriteLine("This was your input: " + userInput);


			// String
			String x8 = "This is A piece of TEXT";
            Console.WriteLine(x8.ToUpper());
            Console.WriteLine(x8.ToLower());
            Console.WriteLine(x8.Contains("is"));
            Console.WriteLine(x8.IndexOf("A"));
            Console.WriteLine(x8.Length);

			// Logic Statements
			if (x1 == 5 && x2 > 2) {
				Console.WriteLine("x1 is " + x1 + " which is equal to 5");
				Console.WriteLine("x2 is " + x2 + " which is larger than 2");
			}

			if (x1 > 10) {
				Console.WriteLine("x1 larger than 10");
			} else if (x1 > 6) {
				Console.WriteLine("x1 larger than 6");
			} else {
				Console.WriteLine("x1 smaller than or equal to 6");
			}

			switch (x1) {
				case 1:
					Console.WriteLine("x1 is 1");
					break;
				case 5:
					Console.WriteLine("x1 is 5");
					break;
				default:
					Console.WriteLine("default case");
					break; // this break is optional in Java
			}

			// Loops
			// while loop
			int count = 0;
			while (count < 2) {
				Console.WriteLine("Welcome to Java from a while loop");
				count++;
			}
			// do-while loop
			count = 0;
			do {
				Console.WriteLine("Welcome to Java from a do-while loop");
				count++;
			} while (count < 2);

			// for loop
			for (int i = 0; i < 2; i++) {
				Console.WriteLine("Welcome to Java from a for loop");
			}

			// continue and break
			for (int i = 0; i < 10; i++) {
				if (i == 2) {
					continue;
				} else if (i == 4) {
					break;
				}
				Console.WriteLine("Welcome to Java from a for loop. i is " + i);
			}

			// Arrays
			int[] arrayOne = { 1, 6, 2, 8, 3 };
			Console.WriteLine(arrayOne.Length);
			Console.WriteLine(arrayOne[2]);

			int[] arrayTwo = new int[3];
			arrayTwo[0] = 3;
			arrayTwo[1] = 7;
			arrayTwo[2] = 92843;
			Console.WriteLine(arrayTwo[1]);

			for (int i = 0; i < arrayTwo.Length; i++) {
				Console.WriteLine("Element " + i + " is " + arrayTwo[i]);
			}


			// Lists
			List<int> listOne = new List<int>();
			listOne.Add(5);
			listOne.Add(9752);
			listOne.Add(16273);
			Console.WriteLine(listOne.Count);
			Console.WriteLine(listOne[0]);

			for (int i = 0; i < listOne.Count; i++) {
				Console.WriteLine(listOne[i]);
			}

			// Equivalent of C#'s foreach(var element in elements) in Java 
			foreach (int element in listOne) {
				Console.WriteLine(element);
			}


			// Calling method
			double x9 = AddNumbers(5.34, 76.1);

			// Creating objects from a class
			Shape s1 = new Shape();
			Console.WriteLine(s1.SayHello());

			Circle c1 = new Circle(5.5);
			Console.WriteLine(c1.GetArea());
			Console.WriteLine(c1.SayHello());

			Shape s2 = new Circle(10);
			Console.WriteLine(s2.SayHello());
		}

		public static double AddNumbers(double d1, double d2) {
			return d1 + d2;
		}
	}
}
