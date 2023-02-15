using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a list of integers separated by spaces: ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        List<int> squares = new List<int>();
        foreach (int number in numbers)
        {
            if (IsSquare(number))
            {
                squares.Add(number);
            }
        }

        squares.Sort();
        squares.Reverse();

        Console.WriteLine("Number squares in decreasing order: " + string.Join(" ", squares));
    }

    static bool IsSquare(int number)
    {
        int root = (int)Math.Sqrt(number);
        return root * root == number;
    }
}
