using System;

namespace MyApplication
{
    // Define the circle class with two constructors
    public class SimpleCircle
    {
        public double radius;

        /** Construct a circle with radius 1 */
        public SimpleCircle()
        {
            radius = 1;
        }

        /** Construct a circle with a specified radius */
        public SimpleCircle(double newRadius)
        {
            radius = newRadius;
        }

        /** Return the area of this circle */
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        /** Return the perimeter of this circle */
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        /** Set a new radius for this circle */
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }
    }


    public class Program
    {
        /** Main method */
        public static void Main(String[] args)
        {
            // Create a circle with radius 1
            SimpleCircle circle1 = new SimpleCircle();
            Console.WriteLine("The area of the circle of radius {0} is {1:N2}.",
                                circle1.radius, circle1.GetArea());

            // Create a circle with radius 25
            SimpleCircle circle2 = new SimpleCircle(25);
            Console.WriteLine("The area of the circle of radius {0} is {1:N2}.",
                                circle2.radius, circle2.GetArea());

            // Create a circle with radius 125
            SimpleCircle circle3 = new SimpleCircle(125);
            Console.WriteLine("The area of the circle of radius {0} is {1:N2}.",
                                circle3.radius, circle3.GetArea());

            // Modify circle radius
            circle2.radius = 100; // or circle2.setRadius(100)
            Console.WriteLine("The area of the circle of radius {0} is {1:N2}.",
                                circle2.radius, circle2.GetArea());
        }
    }

}
