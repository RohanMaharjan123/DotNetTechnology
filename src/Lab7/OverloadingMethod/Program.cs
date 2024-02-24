using System;

class point
{
    //class fields
    int x;
    int y;
    //class constructors
    public point(){

    }
    public point(int a, int b)
    {
        x = a; y = b;
    }
    //methods for overloading <
    public static bool operator< (point p1, point p2)
    {
        double d1 = Math.Sqrt(p1.x * p1.x + p1.y * p1.y);
        double d2 = Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
        return d1 < d2 ? true : false;
    }
    //method for overloading<
    public static bool operator> (point p1, point p2)
    {
        double d1 = Math.Sqrt(p1.x * p1.x + p1.y * p1.y);
        double d2 = Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
        return d1 > d2 ? true : false;
    }
}
class Implementation
{
    static void Main(string[] args)
    {
        point p1 = new point(10, 15);
        point p2 = new point(5, 25);
        point p3 = new point(12, 14);

        Console.WriteLine("(p1 > p2) returns: {0}", (p1 > p2));
        Console.WriteLine("(p1 > p3) returns: {0}", (p1 < p3));
    }
}