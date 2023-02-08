using System;

namespace StatsARR
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(OptionManager.CountLess100(arr));
            Console.WriteLine(OptionManager.Max(arr));
            arr = OptionManager.ReverseArr(arr);
            OptionManager.PrintArr(arr);
            OptionManager.OddNums(arr);
            OptionManager.OddSum(arr);
            //
        }
    }
}
