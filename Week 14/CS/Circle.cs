using System;

namespace ConsoleApp
{
	public class Circle : Shape {
		private double radius;

		public Circle(double r) {
			radius = r;
		}
		public void SetRadius(double r) {
			radius = r;
		}

		public double GetArea() {
			return radius * radius * 3.1415;
		}

		public override String SayHello() {
			return "Hello (Circle)";
		}
	}
}
