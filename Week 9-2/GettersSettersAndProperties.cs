using System;

namespace Project1
{
    public class Circle
    {
        private double _radius;

        // Traditional getter and setter
        public double GetRadius()
        {
            return _radius;
        }

        public void SetRadius(double r)
        {
            if (r > 0)
            {
                _radius = r;
            }
        }
        // Using a "property" to get and set the field
        public double Radius { get => _radius; set => _radius = value; }

        // Using a "property" with validation to get and set the field
        public double RadiusWithValidation
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
            }
        }

        // Using a "property" with auto-gernerated getters and setters
        public double RadiusPrime { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();

            // We cannot do: c1._radius = 10;

            // Working with traditional getter and setter
            c1.SetRadius(10);
            Console.WriteLine(c1.GetRadius());

            // Working with a "property" to get and set the field
            c1.Radius = 10;
            Console.WriteLine(c1.Radius);

            // Working with a "property" with validation to get and set the field
            c1.RadiusWithValidation = 10;
            Console.WriteLine(c1.RadiusWithValidation);

            // Working with a "property" with auto-gernerated getters and setters
            c1.RadiusPrime = 10;
            Console.WriteLine(c1.RadiusPrime);
        }
    }

}
