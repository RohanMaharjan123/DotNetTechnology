using System;
namespace Assembly
{
    class Student
    {
        internal string name = "Shreean";
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student thestudent = new Student();

            Console.WriteLine("Name :" + thestudent.name);
            Console.ReadLine();
        }
    }
}