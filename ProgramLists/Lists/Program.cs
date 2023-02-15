using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a list of integers separated by spaces: ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        int lastNumber = numbers[numbers.Length - 1];
        numbers = numbers.Where(n => n != lastNumber).ToArray();

        Console.WriteLine("Resulting list: " + string.Join(" ", numbers));
    }
}
