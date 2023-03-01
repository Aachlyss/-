using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');

            if (command[0] == "add")
            {
                int index = int.Parse(command[1]);
                int element = int.Parse(command[2]);
                numbers.Insert(index, element);
            }
            else if (command[0] == "addMany")
            {
                int index = int.Parse(command[1]);
                //List<int> elements = command.Skip(2).Select(int.Parse).ToList();
                //numbers.InsertRange(index, elements);
                for (int i = command.Count()-1; i >= 2; i--)
                {
                    numbers.Insert(index,int.Parse(command[i]));
                }
            }
            else if (command[0] == "contains")
            {
                int element = int.Parse(command[1]);
                int index = numbers.IndexOf(element);
                Console.WriteLine(index);
                
            }
            else if (command[0] == "remove")
            {
                int index = int.Parse(command[1]);
                numbers.RemoveAt(index);
            }
            else if (command[0] == "shift")
            {
                int positions = int.Parse(command[1]);
                
                for (int i = 0; i < positions%numbers.Count; i++)
                {
                    int firstElement = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(firstElement);


                }
                
            }
            else if (command[0] == "sumPairs")
            {
                List<int> result = new List<int>();
                for (int i = 0; i < numbers.Count ; i += 2)
                {
                    result.Add(numbers[i] + numbers[i + 1]);
                }
                if (numbers.Count % 2 == 1)
                {
                    result.Add(numbers[numbers.Count - 1]);
                }
                numbers = result;
            }
            else if (command[0] == "print")
            {
                Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                break;
            }
        }
    }
}
