using System;
using System.Linq;

namespace MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimention[0];
            int columns = dimention[1];
            int[,] arr = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = input[j];
                }
            }
            for (int j = 0; j < columns; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
