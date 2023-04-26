using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];

        string[] values = Console.ReadLine().Split();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = int.Parse(values[i * size + j]);
            }
        }

        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine(sum);
    }
}
