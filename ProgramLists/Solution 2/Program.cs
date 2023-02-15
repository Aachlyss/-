using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a list of integers separated by spaces: ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        numbers = numbers.Where(n => n >= 0).ToArray();

        if (numbers.Length == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Array.Reverse(numbers);
            Console.WriteLine("Resulting list: " + string.Join(" ", numbers));
        }
    }
}
