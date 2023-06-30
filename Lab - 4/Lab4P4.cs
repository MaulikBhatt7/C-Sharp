/*
    Write a program to create an abstract class Sum having abstract methods
    SumOfTwo(int a, int b) and SumOfThree(int a, int b,int c). Create another
    class Calculate which extends the abstract class and implements the
    abstract methods.
 */

using System;
abstract class Sum
{
    abstract public int SumOfTwo(int a, int b);
    abstract public int SumOfThree(int a, int b,int c);
}

class Calculate : Sum
{
    override public int SumOfTwo(int a,int b)
    {
        return a + b;
    }
    override public int SumOfThree(int a, int b,int c)
    {
        return a + b + c;
    }

}

class AbstractDemo {    
    public static void Main(string[] args)
    {
        Console.Write("Enter 1st number : ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter 2nd number : ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter 3rd number : ");
        int c = int.Parse(Console.ReadLine());

        Calculate obj = new Calculate();
        
        Console.WriteLine("Addition of two numbers : "+obj.SumOfTwo(a,b));
        Console.WriteLine("Addition of three numbers : " + obj.SumOfThree(a, b,c));

        Console.ReadLine();
    }
}


