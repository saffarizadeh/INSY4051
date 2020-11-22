package lastSession;

public class Circle extends Shape {
	private double radius;
	
	public Circle(double r) {
		radius = r;
	}
	public void setRadius(double r) {
		radius = r;
	}
	public double getArea() {
		return radius * radius * 3.1415;
	}
	@Override
	public String sayHello() {
		return "Hello (Circle)";
	}
}
