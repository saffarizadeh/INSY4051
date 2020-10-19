using System;

namespace MyApplication
{
    public class Student
    {
        public String name; // name has default value null
        public int age; // age has default value 0
        public bool isScienceMajor; // isScienceMajor has default value false
        public char gender; // c has default value '\u0000'
    }

    public class Program
    {
        /** Main method */
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("name is null? " + (student.name == null));
            Console.WriteLine("age? " + student.age);
            Console.WriteLine("isScienceMajor? " + student.isScienceMajor);
            Console.WriteLine("gender is '\\u0000'? " + (student.gender == '\u0000'));
        }
    }

}
