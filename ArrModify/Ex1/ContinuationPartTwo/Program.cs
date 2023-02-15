using System;
using System.Linq;

namespace ContinuationPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string stop = Console.ReadLine();
            while (stop!="END")
            {

                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":                    
                            int index = int.Parse(command[1]);
                        if (index<0 ||index>arr.Length)
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        else
                        {
                            string newWord = command[2];
                            arr[index] = newWord;
                        }
                        break;
                    case "Print":
                        {
                            var result = arr.Where(x => x.StartsWith(command[1])).ToArray();
                            Console.WriteLine(string.Join(" ", arr));
                            break;
                        }

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine(string.Join(", ", arr));
            }
        }
    }
}
