using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] array = Console.ReadLine().Split().ToArray();
        Array.Reverse(array);
        // Reverse the array

        // Deletes the already existent elements
        array = array.Distinct().ToArray();
        Console.WriteLine();

        // Replaces a string with a certain index with something
        int index = 1;
        string replaceWith = "grape";
        array[index] = replaceWith;

        // Prints all strings
        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }
}
