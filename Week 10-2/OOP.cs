using System;

namespace ConsoleApp
{
    public abstract class Animal
    {
        public virtual int MyField { get; set; }
        public abstract string SaySomething();

        public virtual string Sleep()
        {
            return "Zzz";
        }
    }

    public class Dog : Animal
    {
        public override string SaySomething()
        {
            return "Woof!";
        }
    }

    public class Cat : Animal
    {
        public int MyField { get; set; }
        public override string SaySomething()
        {
            return "Meow!";
        }

        public override string Sleep()
        {
            return "Zzz Meow Zzzzzzz";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Console.WriteLine(dog1.SaySomething());
            Console.WriteLine(dog1.Sleep());

            Animal dog2 = new Dog();
            Console.WriteLine(dog2.SaySomething());
            Console.WriteLine(dog2.Sleep());

            Animal cat1 = new Cat();
            Console.WriteLine(cat1.SaySomething());
            // Polymorphism:
            // The overide of the virtual method is invoked at run-time
            Console.WriteLine(cat1.Sleep());

            // Polymorphism:
            // The object of the derived class is treated as an object of the parent class
            Console.WriteLine(CallTheMethod(dog1));
            Console.WriteLine(CallTheMethod(dog2));
            Console.WriteLine(CallTheMethod(cat1));
        }

        static string CallTheMethod(Animal a)
        {
            return a.SaySomething();
        }

        static string CallTheMethod(Dog d)
        {
            return d.SaySomething();
        }
    }
}
