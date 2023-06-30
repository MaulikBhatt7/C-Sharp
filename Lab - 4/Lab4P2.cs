//2. Write a program that reads 5 numbers from user. Demonstrate concept of IndexOutOfRange Exception.

using System;
class InbuiltExceptionDemo
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine("Enter a number : ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter index of element which you want : ");
        
        int index = int.Parse(Console.ReadLine());

        try
        {
            if (index > 4)
            {
                throw new IndexOutOfRangeException("Invalid Index"); 
            }
            Console.WriteLine("Your Element : " + arr[index]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
        
    }
}

