/*
    Write a program to create interface Calculate. In this interface we have two
    member functions Addition() and Subtraction(). Implements this interface
    in another class named Result.
 */

using System;
interface Calculate
{
     public int Addition(int a, int b);
     public int Substraction(int a, int b);
}

class Result : Calculate
{
    public int Addition(int a, int b)
    {
        return a + b;
    }
    public int Substraction(int a, int b)
    {
        return a - b;
    }

}

class AbstractDemo
{
    public static void Main(string[] args)
    {
        Console.Write("Enter 1st number : ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter 2nd number : ");
        int b = int.Parse(Console.ReadLine());

        Result obj = new Result();

        Console.WriteLine("Addition of two numbers : " + obj.Addition(a, b));
        Console.WriteLine("Substraction of two numbers : " + obj.Substraction(a, b));

        Console.ReadLine();
    }
}



