/*1.Write a program to create a class named Candidate with ID, Name, Age,
Weight and Height as data members & also create a member functions like
GetCandidateDetails() and DisplayCandidateDetails(). */


using System;

class Candidate {
    int id;
    String name;
    int age;
    double weight;
    double height;

    
    void GetCandidateDetails()
    {
        Console.Write("Enter id : ");
        this.id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name : ");
        this.name = Console.ReadLine();

        Console.Write("Enter Age : ");
        this.age = int.Parse(Console.ReadLine());

        Console.Write("Enter Weight : ");
        this.weight = double.Parse(Console.ReadLine());

        Console.Write("Enter Height : ");
        this.height = double.Parse(Console.ReadLine());

    }

    void DiplayCandidateDetails()
    {
        Console.WriteLine("ID : " + this.id);
        Console.WriteLine("Name : " + this.name);
        Console.WriteLine("Age : " + this.age);
        Console.WriteLine("Weight : " + this.weight);
        Console.WriteLine("Height : " + this.height);
    }

    public static void Main()
    {
        Candidate c = new Candidate();
        c.GetCandidateDetails();
        Console.WriteLine("----------Candidate's Details-----------");
        c.DiplayCandidateDetails();
        Console.ReadLine();
    }
}





