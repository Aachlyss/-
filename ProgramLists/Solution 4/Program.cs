using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        var result = nums.Where(x => Math.Sqrt(x) == (int)Math.Sqrt(x)).ToList();
        Console.WriteLine(string.Join(" ", result));
    }

}
