using System;
using System.Collections.Generic;
using System.Linq;

namespace LastSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0]=="end")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Contains":
                        int numberu = Convert.ToInt32(command[1]);
                        if (numbers.Contains(numberu))
                        {
                            Console.WriteLine("Yes");
                        }
                        if (numbers!.Contains(numberu))
                        {
                            Console.WriteLine("No such nummber!");
                        }
                        break;
                    case "PrintEven":
                            Console.WriteLine(string.Join(' ',numbers.Where(x=>x%2==0)));
                        break;
                    case "Filter":
                        break;
                }
            }
        }
    }
}
