//Write a program to calculate area of a Rectangle using constructor.


using System;

class AreaOfRectangle {
    double length;
    double breadth;

    public AreaOfRectangle(double length,double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }
    
    double CalculateArea() {
        
        return this.length * this.breadth;
    }

    public static void Main(String[] args)
    {

        Console.Write("Enter lenght : ");
        double length=double.Parse(Console.ReadLine());

        Console.Write("Enter breadth : ");
        double breadth = double.Parse(Console.ReadLine());

        AreaOfRectangle obj = new AreaOfRectangle(length,breadth);

        Console.WriteLine("Area of Rectangel is : " + obj.CalculateArea().ToString());


    }


}
