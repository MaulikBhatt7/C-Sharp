/*
	Write a program for implementing single inheritance which 	creates one class Account_Details for getting account 	information and another class Interest for calculating and 	displaying total interest from the data inserted from 	account details.
*/


using System;

class Account_Details_Demo
{
    public static void Main(string[] args)
    {
        Interest interest = new Interest();
    }
}

class Account_Details
{
    public int accountid;
    public string username;
    public double principle;
    public double rate;
    public double time;

    public Account_Details() 
    {
        Console.WriteLine("Please enter Account ID : ");
        this.accountid = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Username : ");
        this.username = Console.ReadLine();
        Console.WriteLine("Please enter Principle rate : ");
        this.principle = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Rate : ");
        this.rate = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter time : ");
        this.time = double.Parse(Console.ReadLine());
    }
}

class Interest:Account_Details
{
    public Interest()
    {
        Console.WriteLine("The interest is : {0}%",((principle*rate*time)/100));
    }
}
