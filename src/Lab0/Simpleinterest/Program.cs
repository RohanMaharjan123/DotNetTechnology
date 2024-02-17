// See https://aka.ms/new-console-template for more information
using System;

namespace Simpleinterest
{
    internal class Program
    {
        static void Main(string[] args){
            // program to calculate SI
            float p = 100000, t = 10, r = 8, SI;

            SI = (p * t * r)/100;
            Console.WriteLine(SI);
            Console.ReadLine();
        }
    }
}
