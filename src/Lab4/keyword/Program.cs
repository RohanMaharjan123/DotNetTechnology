using System;

namespace keyword
{
    class Test
    {
        int num;
        Test(int num)
        {
            //this.num refers to the instance field
            this.num = num;
        }
        static void Main(string[] args)
        {
            Test t1 =  new Test(4);
            Console.WriteLine("Value of num :" + t1.num);
            Console.ReadLine();
        }
    }
}