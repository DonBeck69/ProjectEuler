using System;
using System.IO;
using System.Numerics;

namespace _13___LargeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //load text file
            string[] lines = System.IO.File.ReadAllLines(@"./numbers.txt");
            LargeSum ls = new LargeSum();

            BigInteger[] bigs = ls.SringToBigs(lines);
            BigInteger sum = ls.SumBigs(bigs);

            // get digets in array from right to left
            short[] digits = ls.NumberToArray(sum);
            string firstDigits = string.Empty;

            //backwards
            for(int index = digits.Length - 1; index >= digits.Length - 10; index--)
            {
                firstDigits += digits[index].ToString();

            }


            Console.WriteLine($"First 10 digits are {firstDigits}");
        }
    }

    public class LargeSum
    {


        public BigInteger SumBigs(BigInteger[] Bigs)
        {
            BigInteger sumBig = 0;
            foreach(BigInteger big in Bigs)
            {
                sumBig += big;
            }

            return sumBig;
        }

        // convert any number to array of digits
        public short[] NumberToArray(BigInteger Number)
        {
            short[] digits = new short[0];
            Console.WriteLine(Number.ToString());
            while (Number != 0)
            {
                short diget = (short)(Number % 10);
                Console.WriteLine(diget.ToString());
                Number = Number / 10;
                Console.WriteLine(Number.ToString());
                Array.Resize(ref digits, digits.Length + 1);
                digits[digits.Length - 1] = diget;
            }

            return digits;
        }


        //convert an arry of numbers as strings in an array to an array of BigIntegers
        public BigInteger[] SringToBigs(string[] strings)
        {
            BigInteger[] bigs = new BigInteger[strings.Length];
            for(int index = 0; index <= strings.Length - 1; index++)
            {
                bigs[index] = BigInteger.Parse(strings[index]);
            }

            return bigs;
        }

    }
}
