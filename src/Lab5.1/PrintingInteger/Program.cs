using System;

namespace PrintingInteger
{
    class Programcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is {0}", num);
            Console.ReadKey();
        }
    }
}