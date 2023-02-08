using System;

namespace StatArr
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
            Console.WriteLine(OptionManager.MaxNum(arr));
            arr = OptionManager.Reverce(arr);
            OptionManager.PrintArr(arr);
            //
        }
    }
}
