package lastSession;

import java.util.*;

public class Program {

	public static void main(String[] args) {
		
		// Variables
		int x1 = 5;
		double x2 = 3.1415;
		String x3 = "123.45";
		
		// Type Conversion
		double x4 = x1;
		int x5 = (int) x1;
		double x6 = Double.parseDouble(x3);
		String x7 = String.valueOf(x2);
		// OR
		x7 = Double.toString(x2);
		
		// Basic I/O
		// Shortcut: type sysout and press Ctrl + space
		System.out.println(x1);
		System.out.println("This is the output: " + x2 + " " + x3);
		Scanner reader = new Scanner(System.in);
		System.out.print("Enter something: ");
		String userInput = reader.nextLine();
		System.out.println("This was your input: " + userInput);
		
		// String
		// For formatting see:
		// https://docs.oracle.com/javase/tutorial/java/data/numberformat.html
		// Learn more about the String class and its methods:
		// https://docs.oracle.com/javase/7/docs/api/java/lang/String.html
		// OR https://www.w3schools.com/java/java_ref_string.asp
		String x8 = "This is A piece of TEXT";
		System.out.println(x8.toUpperCase());
		System.out.println(x8.toLowerCase());
		System.out.println(x8.contains("is"));
		System.out.println(x8.indexOf("A"));
		System.out.println(x8.length());
		
		// Logic Statements
		if(x1 == 5 && x2 > 2) {
			System.out.println("x1 is " + x1 + " which is equal to 5");
			System.out.println("x2 is " + x2 + " which is larger than 2");
		}
		
		if (x1 > 10) {
			System.out.println("x1 larger than 10");
		} else if (x1 > 6) {
			System.out.println("x1 larger than 6");
		} else {
			System.out.println("x1 smaller than or equal to 6");
		}
		
		switch(x1) {
			case 1:
				System.out.println("x1 is 1");
				break;
			case 5:
				System.out.println("x1 is 5");
				break;
			default:
				System.out.println("default case");
				break; // this break is optional in Java
		}
		
		// Loops
		// while loop
		int count = 0;
		while (count < 2) {
			System.out.println("Welcome to Java from a while loop");
			count++;
		}
		// do-while loop
		count = 0;
		do {
			System.out.println("Welcome to Java from a do-while loop");
			count++;
		} while (count < 2);
			
		// for loop
		for(int i = 0; i < 2; i++) {
			System.out.println("Welcome to Java from a for loop");
		}
		
		// continue and break
		for(int i = 0; i < 10; i++) {
			if(i == 2) {
				continue;
			}
			else if(i==4) {
				break;
			}
			System.out.println("Welcome to Java from a for loop. i is " + i);
		}
		
		// Arrays
		int[] arrayOne = {1, 6, 2, 8, 3};
		System.out.println(arrayOne.length);
		System.out.println(arrayOne[2]);
		
		int[] arrayTwo = new int[3];
		arrayTwo[0] = 3;
		arrayTwo[1] = 7;
		arrayTwo[2] = 92843;
		System.out.println(arrayTwo[1]);
		
		for(int i = 0; i < arrayTwo.length; i++) {
			System.out.println("Element " + i + " is " + arrayTwo[i]);
		}
		
		// Lists
		ArrayList<Integer> listOne = new ArrayList<Integer>();
		listOne.add(5);
		listOne.add(9752);
		listOne.add(16273);
		System.out.println(listOne.size());
		System.out.println(listOne.get(0));
		
		for(int i = 0; i < listOne.size(); i++) {
			System.out.println(listOne.get(i));
		}
		
		// Equivalent of C#'s foreach(var element in elements) in Java 
		for(int element : listOne) {
			System.out.println(element);
		}
		
		// Calling method
		double x9 = addNumbers(5.34, 76.1);
		
		// Creating objects from a class
		Shape s1 = new Shape();
		System.out.println(s1.sayHello());
		
		Circle c1 = new Circle(5.5);
		System.out.println(c1.getArea());
		System.out.println(c1.sayHello());
		
		Shape s2 = new Circle(10);
		System.out.println(s2.sayHello());
	}
	
	public static double addNumbers(double d1, double d2) {
		return d1 + d2;
	}
}
