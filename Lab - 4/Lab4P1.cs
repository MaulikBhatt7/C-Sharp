//Write a program to Create a divide by zero exception and handle it.

using System;
class ZeroDivisonException {
    public static void Main(String[] args) {
        Console.WriteLine("Enter a number : ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number : ");
        double b = double.Parse(Console.ReadLine());

        try
        {
            if (b == 0)
            {
                throw (new DivideByZeroException("Number can't be divided by Zero"));
            }
            Console.WriteLine("Division = " + a / b);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }


}

