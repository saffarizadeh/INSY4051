using System;

namespace Project1
{
    public class Circle
    {
        private static int numberOfObjects;

        public static int GetNumberOfObjects()
        {
            return numberOfObjects;
        }
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            numberOfObjects++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine("Circle 1 radius: " + c1.Radius);
            Console.WriteLine("Number of objects in class: " + Circle.GetNumberOfObjects());
            Circle c2 = new Circle(10);
            Console.WriteLine("Circle 2 radius: " + c2.Radius);
            Console.WriteLine("Number of objects in class: " + Circle.GetNumberOfObjects());
            Circle c3 = new Circle(20);
            Console.WriteLine("Circle 3 radius: " + c3.Radius);
            Console.WriteLine("Number of objects in class: " + Circle.GetNumberOfObjects());
        }
    }
}
