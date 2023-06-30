/*
    Create a class Furniture with material, price as data members. Create
    another class Table with Height, surface_area as data members. Write a
    program to implement single inheritance.
*/

using System;
    class Furniture
    {
        String material;
        double price;

        public void printFurniture()
        {
            Console.WriteLine("Furniture Class");
        }
    }
    class Table : Furniture {
        double height;
        String surfaceArea;

        public void printTable()
        {
            Console.WriteLine("Table Class");
        }
    }

    class InheritanceDemo
    {
        public static void Main(String[] args)
        {
            Table t = new Table();
            t.printTable();
            t.printFurniture();
            
        }
    }




