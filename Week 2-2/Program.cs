using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////

            Console.WriteLine("Hello World!");

            /////////////////////////////////////////

            // this is a single-line comment
            int x1 = 5; // a single-line comment after code

            /* This is also a
             * comment spanning
             * multiple lines */
            int x2 = 5;
            Console.WriteLine(x2);

            /////////////////////////////////////////

            string name = "John";
            Console.WriteLine(name);

            int myNum1;
            myNum1 = 15;
            Console.WriteLine(myNum1);

            int myNum2 = 15;
            myNum2 = 20; // myNum is now 20
            Console.WriteLine(myNum2);

            /////////////////////////////////////////

            const int myNum = 15;
            // myNum = 20; // error

            /////////////////////////////////////////

            int myNum3 = 5;                  // Integer (whole number)
            Console.WriteLine(myNum3);       // 5

            double myDoubleNum = 5.99D;     // Floating point number
            Console.WriteLine(myDoubleNum); // 5.99

            char myLetter = 'D';            // Character
            Console.WriteLine(myLetter);    // D

            bool myBool = true;             // Boolean
            Console.WriteLine(myBool);      // True

            string myText = "Hello";        // String
            Console.WriteLine(myText);      // Hello

            /////////////////////////////////////////

            int i;
            int j;
            int result;
            i = 10;
            j = 5;
            result = i + j;  // 15
            result = i - j;  // 5
            result = i * j;  // 50
            result = i / j;  // 2
            result = i % 3;  // 1
            i = i + 2;       // 12
            i = 10;          // 10
            i += 2;          // 12
            i -= 2;          // 10
            result = i++;    // 10
            result = ++j;    // 6
            j--;             // 5

            /////////////////////////////////////////

            double x3;
            x3 = (3 - 2) * 2 - 1 * 5 / 2.0;
            Console.WriteLine(x3);           // -0.5

            /////////////////////////////////////////

            double applePrice = 0.99D;
            Console.WriteLine("Enter the number apples you need:");
            string userInputText = Console.ReadLine();
            int numberOfApples = Convert.ToInt32(userInputText);
            double totalPrice = numberOfApples * applePrice;
            Console.WriteLine("Total price: " + totalPrice);

            /////////////////////////////////////////

        }
    }
}
