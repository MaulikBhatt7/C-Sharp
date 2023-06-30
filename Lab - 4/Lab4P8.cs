//Write a program to Replace lower case characters to upper case and Vice - versa.

using System;
class CharacterConvertion
{
    public static void Main(String[] args)
    {
        string str = "Darshan University";
        string result = "";
        foreach (char c in str)
        {
            if (Char.IsUpper(c))
            {
                result += c.ToString().ToLower();
            }
            else
            {
                result += c.ToString().ToUpper();
            }
        }
        Console.WriteLine("Result = "+result);
    }
}

