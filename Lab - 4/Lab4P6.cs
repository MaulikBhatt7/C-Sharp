/*
    Write a program to create interface named Shape. In this interface, we
    have three methods Circle(), Triangle() and Square() which calculates area
    of Circle, Triangle and Square respectively. Implement Shape interface.
 */

using System;
interface Shape {
    public double Circle(double radius);
    public double Triangle(double h, double b);
    public double Square(double l);
}

class ImplementDemo : Shape
{
    public double Circle(double radius)
    {
        return 3.14 * radius * radius;
    }
    public double Triangle(double h,double b)
    {
        return 0.5 * h * b;
    } 
    public double Square(double l)
    {
        return l * l;
    }
}

class InterfaceDemo {
    public static void Main(String[] args)
    {
        ImplementDemo obj = new ImplementDemo();
        Console.WriteLine("Area of circle = "+obj.Circle(10));
        Console.WriteLine("Area of triangle = " + obj.Triangle(15, 10));
        Console.WriteLine("Area of Square = " + obj.Square(20));

        Console.ReadLine();
    }
}























