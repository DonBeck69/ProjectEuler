using System;
using System.IO;

using Solutions;

namespace _67___MaxPathSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"./triangle2.txt"); // triangle1 // triangle2
            int[][] triangle= new int[lines.Length][];
            MaxPath mp = new MaxPath();
            ArrayFunctions sat = new ArrayFunctions();
            for (int index = 0; index <= lines.Length - 1; index++)
            {
                string[] strings = lines[index].Split(' ', StringSplitOptions.None);
                triangle[index] = sat.ToIntArray(strings);

            }

            int max = mp.CalculateMax(triangle);

            Console.WriteLine($"Max is {max}");
        }
    }
}
