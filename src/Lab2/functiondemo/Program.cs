using System;
namespace functiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            UpdateValue(a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        private static void UpdateValue(int b)
        {
            b = 30;
        }
    }
}