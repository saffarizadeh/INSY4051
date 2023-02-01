namespace AssignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
        }

        static void Q1()
        {
            Console.WriteLine("---USD to Chinese Yuan Converter---");
            Console.WriteLine("Please enter a USD value:");
            // try/catch block is optional
            int usd = Convert.ToInt32(Console.ReadLine());
            double cny = usd * 6.43;
            Console.WriteLine(cny + " Chinese Yuan");
        }
        static void Q2()
        {
            Console.WriteLine("---Celsius to Fahrenheit Converter---");
            Console.WriteLine("Please enter an integer temperature in Celsius:");
            // try/catch block is optional
            int c = Convert.ToInt32(Console.ReadLine());
            double f = (c * 9.0 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: " + f);
        }

        static void Q3()
        {
            Console.WriteLine("---Simple Average Calculator---");
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int c = Convert.ToInt32(Console.ReadLine());

            double average = (a + b + c) / 3.0;
            Console.WriteLine("The average is " + average);
        }
    }
}
