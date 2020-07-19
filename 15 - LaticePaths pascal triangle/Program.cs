using System;

namespace _15___LaticePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            LaticePaths lp = new LaticePaths();
            short grid = 20;
            int rows = grid + grid + 1;
            long[,] pascal = lp.GetPascal(rows);
            long one = pascal.GetLength(0) - 1;
            long two = one / 2;
            //long v = pascal.GetLength(1) - 1;

            long pathCount = pascal[one, two];

            Console.WriteLine($"Path Count {pathCount}");
        }
    }

    public class LaticePaths
    {
        public long[,] GetPascal(int rows)
        {
            long[,] pascal = new long[rows, rows];

            for (long line = 0; line < rows; line++)
            {
                for (long number = 0; number <= line; number++)
                {
                    if (line == number || number == 0)
                    {
                        pascal[line, number] = 1;
                    }
                    else
                    {
                        pascal[line, number] = pascal[line - 1, number - 1] + pascal[line - 1, number];
                    }
                }
            }

            return pascal;

        }
    }
}
