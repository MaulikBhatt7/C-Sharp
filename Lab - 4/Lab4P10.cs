// 10.Write a program to change the case of entered character.

using System;

class CharacterChange
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a character : ");
        char c = Console.ReadLine().ToCharArray()[0];

        //Convert char to string and change case of it
        char ans = c.ToString().ToUpper().ToCharArray()[0];

        Console.WriteLine("Changed case of character : "+ans);

        Console.ReadLine();
    }
}
