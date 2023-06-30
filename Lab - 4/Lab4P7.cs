//Write program showing use of common methods of String class.

using System;
class StringMethods
{
    public static void Main()
    {
        string text = "Hello, World!";

        // Length property
        int length = text.Length;
        Console.WriteLine("Length: " + length);

        // Substring method
        string substring = text.Substring(7);
        Console.WriteLine("Substring: " + substring);

        // IndexOf method
        int index = text.IndexOf("World");
        Console.WriteLine("Index of 'World': " + index);

        // Contains method
        bool contains = text.Contains("Hello");
        Console.WriteLine("Contains 'Hello': " + contains);

        // Replace method
        string replaced = text.Replace("World", "OpenAI");
        Console.WriteLine("Replaced: " + replaced);

        // ToUpper method
        string upperCase = text.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);

        // ToLower method
        string lowerCase = text.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);

        // Split method
        string[] words = text.Split(',');
        Console.WriteLine("Split:");
        foreach (string word in words)
        {
            Console.WriteLine(word.Trim());
        }

        // StartsWith method
        bool startsWith = text.StartsWith("Hello");
        Console.WriteLine("Starts with 'Hello': " + startsWith);

        // EndsWith method
        bool endsWith = text.EndsWith("!");
        Console.WriteLine("Ends with '!': " + endsWith);

        // Concatenation
        string concatenated = string.Concat(text, " It's a beautiful day!");
        Console.WriteLine("Concatenated: " + concatenated);

        // Format method
        string formatted = string.Format("The text is: {0}", text);
        Console.WriteLine("Formatted: " + formatted);

        // Trim method
        string trimmed = "   Some spaces    ";
        string trimmedResult = trimmed.Trim();
        Console.WriteLine("Trimmed: " + trimmedResult);

        Console.ReadLine();
    }
}

