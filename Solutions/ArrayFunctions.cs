using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class ArrayFunctions
    {
        public int[] ToIntArray(string[] strings)
        {
            int[] ints = new int[strings.Length];
            for(int index = 0; index <= strings.Length - 1; index++)
            {
                int number;
                if (int.TryParse(strings[index], out number))
                {
                    ints[index] = number;
                }
            }

            return ints;
        }

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

        public short[] NumberToArray(long Number)
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

    }
}
