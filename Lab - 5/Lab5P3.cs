//Write a programs to Find Area of Square, Rectangle and Circle using Method Overloading.


using System;
class OverloadingDemo
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter length of Square : ");
        double l = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Length of Rectangle : ");
        double l2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter breadth of Recangle : ");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter radius of Circle : ");
        int r = int.Parse(Console.ReadLine());

        Console.WriteLine("Area of Square = " + Area(l));
        Console.WriteLine("Area of Rectangle = " + Area(l2, b2));
        Console.WriteLine("Area of Circle = " + Area(r));

        Console.ReadLine();
    }

    public static double Area(double l)
    {
        return l * l;
    }
    public static double Area(double l, double b)
    {
        return l * b;
    }

    public static double Area(int r)
    {
        return 3.14*r*r;
    }
}
