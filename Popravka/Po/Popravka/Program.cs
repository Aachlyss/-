using System;
using System.Collections.Generic;
using System.Linq;

namespace Popravka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                List<string> curent = Console.ReadLine().Split(' ').ToList();
if (curent[0] == "stop")
{
                    Console.WriteLine("[{0}]", string.Join(", ", input));
                    break;
                }
                if (curent[0] == "ins")
{
                    int index = int.Parse(curent[0]);
                    string element = curent[1];
                    input.Add(index, element);
                }
                if (curent[0] == "contains")
{
                    int serachedNumber = int.Parse(curent[1]);
                    Console.WriteLine(input.Contains(serachedNumber));
                }
                if (curent[0] == "remove")
{
                    input.Remove(removedNumber);
                }
            }
        }
    }
}
