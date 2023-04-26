using System;
using System.Linq;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimention[0];
            int columns = dimention[1];
            int[,] arr = new int[rows, columns];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split("; ").Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            foreach (var item in arr)
            {
                /* if (item <=20)
                 {
                     sum += item;
                 }*/
                Console.WriteLine(item+" ");
            }
            Console.WriteLine(sum);
        }
    }
}
