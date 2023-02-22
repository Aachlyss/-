using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the lists of numbers separated by '|': ");
        string input = Console.ReadLine();
        string[] lists = input.Split('|');
        lists.Reverse();

        List<List<int>> mergedLists = new List<List<int>>();
        foreach (string list in lists)
        {

            List<int> numbers = list.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();
            numbers.Reverse();
            mergedLists.Add(numbers);
        }

        
        mergedLists.Sort((list1, list2) => list2.Count - list1.Count);

        List<int> mergedNumbers = new List<int>();
        
        foreach (List<int> list in mergedLists)
        {
            
            mergedNumbers.AddRange(list);
           
        }      
        

        Console.WriteLine("Merged and sorted list: " + string.Join(" ", mergedNumbers));
        
    }
}
