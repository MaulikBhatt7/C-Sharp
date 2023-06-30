using System;

class Employee_Demo
{
    public static void Main(string[] args)
    {
        Salary s = new Salary();
        s.basic_sal();
        s.display_sal();
        s.gross_sal();
    }
    
}

class Employee
{
    string name;
    double basic_salary;

    public void basic_sal()
    {
        Console.WriteLine("Please enter basic salary : ");
        this.basic_salary = double.Parse(Console.ReadLine());
    }
}

interface Gross
{
    public void gross_sal();
}

class Salary:Employee , Gross
{
    double hra, ta = 0, da;

    public void gross_sal()
    {
        Console.WriteLine("Gross salary : ", (basic_sal +basic_sal* hra + ta + basic_sal* da));
    }
    public void display_sal()
    {
        Console.WriteLine("Salary : ",(basic_sal+hra+ta+da));
    }
}
