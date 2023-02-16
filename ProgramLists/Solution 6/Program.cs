using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        char[] delimiters = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\\', '/', '[', ']', ' ' };
        List<string> lowercaseWords = new List<string>();
        List<string> uppercaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();
        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.All(char.IsLower))
            {
                lowercaseWords.Add(word);
            }
            else if (word.All(char.IsUpper))
            {
                uppercaseWords.Add(word);
            }
            else
            {
                mixedCaseWords.Add(word);
            }
        }

        Console.WriteLine("Lowercase words:");
        Console.WriteLine(string.Join(", ", lowercaseWords));
        Console.WriteLine();
        Console.WriteLine("Uppercase words:");
        Console.WriteLine(string.Join(", ", uppercaseWords));
        Console.WriteLine();
        Console.WriteLine("Mixed case words:");
        Console.WriteLine(string.Join(", ", mixedCaseWords));
    }
}
