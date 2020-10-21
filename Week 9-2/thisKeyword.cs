
namespace Project1
{
    public class Circle
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle() : this(1.0) { }
    }
}
