/* Write a program using method overloading by changing datatype of
arguments to perform addition of two integer numbers and two float
numbers.*/

using System;

class OverloadingDemo
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter 1st Integer number : ");
        int a1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd Integer number : ");
        int b1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 1st Double number : ");
        double a2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd Double number : ");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Addition of Integers = " + Addition(a1, b1));
        Console.WriteLine("Addition of Doubles = " + Addition(a2, b2));

        Console.ReadLine();
    }

    public static int Addition(int a,int b)
    {
        return a + b;
    }
    public static double Addition(double a,double b)
    {
        return a + b;
    }
}
