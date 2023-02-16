using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        bool listChanged = false;

        while (true)
        {
            string[] command = Console.ReadLine().Split(' ');
            if (command[0] == "end")
            {
                if (listChanged)
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                break;
            }
            switch (command[0])
            {
                case "Contains":
                    int num = int.Parse(command[1]);
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                    break;
                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                    break;
                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;
                case "Filter":
                    int numFilter = int.Parse(command[2]);
                    switch (command[1])
                    {
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < numFilter)));
                            break;
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > numFilter)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= numFilter)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= numFilter)));
                            break;
                    }
                    break;
                default:
                    break;
            }
            listChanged = true;
        }
    }
}
