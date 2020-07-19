using System;

namespace _6___SumSquareDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            SumSquareDiff ssd = new SumSquareDiff();

            long result = ssd.GetSumSquareDiff(100);

            Console.WriteLine($"Diff between sum squares are {result}");
        }
    }

    public class SumSquareDiff
    {
        public long GetSumSquareDiff(int Max)
        {
            long result = 0;
            long squareTot = 0;
            long total = 0;
            for (int number = 1; number <= Max; number++)
            {
                total += number;
                squareTot += number * number;
            }
            total = total * total;
            result = total - squareTot;
            return result;

        }
    }
}
