using System;

namespace _2___Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciNumbers fibonacciNumbers = new FibonacciNumbers();

            int result = fibonacciNumbers.CalculateEvens(4000000);
            Console.WriteLine($"Result is {result}");
        }
    }

    public class FibonacciNumbers
    {
        public int CalculateEvens(int Max)
        {
            int ret = 0;

            //build fibonacci
            int[] fibonacciTerms = BuildFibonacciTerms(Max);

            //loop fibonacciTerms to find and add even numbers
            for (int index = 1; index < fibonacciTerms.Length; index++)
            {
                if ((fibonacciTerms[index] % 2) == 0)
                {
                    ret += fibonacciTerms[index];
                }
            }


            return ret;
        }

        public int[] BuildFibonacciTerms(int Max)
        {
            int[] fibonacciTerms = new int[] {1, 2};
            int term = 3;
            while (term < Max)
            {
                term = fibonacciTerms[fibonacciTerms.Length - 1] + fibonacciTerms[fibonacciTerms.Length - 2];
                if (term < Max)
                {
                    Array.Resize(ref fibonacciTerms, fibonacciTerms.Length + 1);
                    fibonacciTerms[fibonacciTerms.GetUpperBound(0)] = term;
                }
            }

            return fibonacciTerms;
        } 
    }
}
