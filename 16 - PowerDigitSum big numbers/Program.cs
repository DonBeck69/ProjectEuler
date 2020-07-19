using System;
using System.Numerics;

namespace PowerDigits
{
    class Program
    {
        static void Main(string[] args)
        {


            PowerDigitSum pds = new PowerDigitSum();
            BigInteger bigPow = pds.GetPower(2, 1000);
            short[] digits = pds.NumberToArray(bigPow);

            long digitSum = 0;
            for (int index = 0; index <= digits.Length - 1; index++)
            {
                digitSum += digits[index];
                //Console.WriteLine($"digitSum: {digits[index]}");
            }

            Console.WriteLine($"Sum of digits is {digitSum}");
        }
    }

    public class PowerDigitSum
    {
        public short[] NumberToArray(BigInteger Number)
        {
            short[] digits = new short[0];
            //Console.WriteLine(Number.ToString());
            int count = 0;
            while (Number != 0)
            {
                short diget = (short)(Number % 10);
                //Console.WriteLine(diget.ToString());
                Number = Number / 10;
                //Console.WriteLine(Number.ToString());
                Array.Resize(ref digits, digits.Length + 1);
                digits[digits.Length - 1] = diget;
                count++;

            }

            //Console.WriteLine($"count {count}");
            return digits;
        }

        public BigInteger GetPower(int num, int pow)
        {
            pow -= 2;
            BigInteger big = num;
            for(int count = 0; count <= pow; count++)
            {
                big *= num;
                Console.WriteLine($"big {big}");
            }

            return big;
        }

    }
}
