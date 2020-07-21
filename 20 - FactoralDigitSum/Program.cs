using System;
using System.Dynamic;
using Solutions;
using System.Numerics;

namespace _20___FactoralDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayFunctions arrayFunctions = new ArrayFunctions();

            int max = 100;
            BigInteger factTot = max;
            int tot = 0;
            for (int fact = max -1; fact >= 1; fact--)
            {
                factTot *= fact;
            }

            short[] numbers = arrayFunctions.NumberToArray(factTot);
            foreach (short number in numbers)
            {
                tot += number;
            }

            Console.WriteLine($"Total is {tot}");
        }
    }
}
