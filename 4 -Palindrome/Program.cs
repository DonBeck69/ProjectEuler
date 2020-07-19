using System;

namespace _4__Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop digits
            // test for pal
            // store in array
            // find max (technicly it will be the last one found.) 
            PalindromeCalculator pc = new PalindromeCalculator();
            long pal = pc.GetPalindrome(3);

            //bool test1 = pc.TestForPal(123);
            //bool test11 = pc.TestForPal(121);
            //bool test2 = pc.TestForPal(1234);
            //bool test3 = pc.TestForPal(12321);
            //bool test4 = pc.TestForPal(123321);



            //long[] testArray = new long[] {1,2,3, 4, 5, 6};
            //long [] splitArray = pc.ArraySplitter(3, 3, testArray);
            //long[] reverseN = pc.ReverseArray(testArray);

            //long testNumber = 987789;
            //long[] result = pc.NumberToArray(testNumber);
            //long testNumberBack = pc.ArrayToNumber(result);

            Console.WriteLine("Hello World!");
        }
    }

    public class PalindromeCalculator
    {
        public long GetPalindrome(int digit)
        {
            long maxPal = 0;
            int maxNumber = this.CalcMaxNumberForDigits(digit);
            
            for (int countLeft = 2; countLeft <= maxNumber; countLeft++)
            {
                for (int countRight = 1; countRight <= maxNumber; countRight++)
                {
                    long result = countRight * countLeft;
                    if (this.TestForPal(result))
                    {
                        if (result > maxPal)
                        {
                            maxPal = result;
                        }
                    }
                }
            }

            return maxPal;
        }

        public bool TestForPal(long Pal)
        {
            bool isPal = false;
            // should be more than 1 digit, and positive
            if (Pal > 9)
            {
                long[] numberArray = this.NumberToArray(Pal);
                long[] reverseArray = this.ReverseArray(numberArray);
                long reversePal = this.ArrayToNumber(reverseArray);

                if (Pal == reversePal)
                {
                    isPal = true;
                }
            }
            return isPal;
        }

        public int CalcMaxNumberForDigits(int digits)
        {
            int max = 9;
            int addVal = 10;
            for (int digit = 1; digit < digits; digit++)
            {
                max += addVal * 9;
                addVal *= 10;
            }
            return max;
        }

        // convert any number to array of digits
        public long[] NumberToArray(long Number)
        {
            long digets = Convert.ToInt32(Math.Floor(Math.Log10(Number) + 1));
            long[] result = new long[digets];
            for (int index = result.Length - 1; index >= 0; index--)
            {
                result[index] = Number % 10;
                Number /= 10;
            }

            return result;
        }

        public long ArrayToNumber(long[] NumberArray)
        {
            long result = 0;
            int digitCount = 1;
            for (int index = NumberArray.Length - 1; index >= 0; index--)
            {
                result += NumberArray[index] * digitCount;
                digitCount *= 10;
            }

            return result;
        }

        public long[] ReverseArray(long[] NumberArray)
        {
            long[] reverseNumberArray = new long[] { 0 };
            reverseNumberArray[0] = NumberArray[NumberArray.Length - 1];
            for (int index = NumberArray.Length - 2; index >= 0; index--)
            {
                Array.Resize(ref reverseNumberArray, reverseNumberArray.Length + 1);
                reverseNumberArray[reverseNumberArray.Length - 1] = NumberArray[index];
            }

            return reverseNumberArray;
        }


        public long[] MergeArrays(long[] Left, long[] Right)
        {
            long[] merged = new long[] { 0 };
            int totalIndex = 0;
            for (int index = 0; index <= Left.Length - 1; index++)
            {
                Array.Resize(ref merged, merged.Length + 1);
                merged[totalIndex] = Left[index];
                ++totalIndex;
            }
            for (int index = 0; index <= Right.Length - 1; index++)
            {
                Array.Resize(ref merged, merged.Length + 1);
                merged[totalIndex] = Left[index];
                ++totalIndex;
            }

            return merged;

        }

        public long[] ArraySplitter(int Start, int Take, long[] NumberArray)
        {
            long[] newArray = new long[] { NumberArray[Start] };
            //int newIndex = 1;
            for (int index = Start + 1; index <= Start + Take - 1; index++)
            {
                Array.Resize(ref newArray, newArray.Length + 1);
                newArray[newArray.Length - 1] = NumberArray[index];
                //newIndex++;
            }

            return newArray;
        }

    }
}
