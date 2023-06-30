//Write a program to accept a number from the user and throw an exception if the number is not an even number

using System;
public class OddNumberException : Exception
{
    public OddNumberException(String message) : base(message) { }
}

class CustomExceptionDemo { 
    public static void Main(String[] args)
    {
        Console.Write("Enter a numebr : ");
        int n = int.Parse(Console.ReadLine());

        try {
            if (n % 2 != 0)
            {
                throw new OddNumberException(n+" is Odd Number which is not allowed");
            }
            Console.WriteLine("Your Even number is : "+n);
        }
        catch (OddNumberException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}


