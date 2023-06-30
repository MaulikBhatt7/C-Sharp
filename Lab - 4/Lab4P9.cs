//Write a program to find the longest word in a string.

using System;
class LongestWord
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();

        List<String> wordList = str.Split(" ").ToList();
        string longestWord = "";

        foreach (String word in wordList)
        {
            if (longestWord.Length < word.Length)
            {
                longestWord = word;
            }
        }
        //Single longest word
        Console.WriteLine("Longest word is : "+longestWord);

        Console.ReadLine();
    }
}
