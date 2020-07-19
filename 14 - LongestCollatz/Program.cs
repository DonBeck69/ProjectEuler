using System;

namespace _14___LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestCollatz lc = new LongestCollatz();
            int longest = lc.GetLongestCollatz(1000000);

            Console.WriteLine($"Longest Collatz Sequence number is {longest}");
        }
    }

    public class LongestCollatz
    {

        public int GetLongestCollatz(int Below)
        {
            int longestCollatz = 0;
            int cNum = 0;
            int halfBelow = Below / 2;
            Below -= 1;
            // the number with highest steps is in the top 60% of the below number - play it safe and go with "half"
            for (long count = Below; count > halfBelow; count--)
            {
                int collatzCount = GetCollatzCount(count);
                if (collatzCount > longestCollatz)
                {
                    longestCollatz = collatzCount;
                    cNum = Convert.ToInt32(count);
                }
            }

            return cNum;
        }

        public int GetCollatzCount(long Number)
        {
            int count = 0;
            while(Number > 1)
            {
                if (Number % 2 == 0)
                {
                    Number /= 2;
                }
                else{
                    Number *= 3;
                    Number++;
                }

                count++;
            }

            return count;
        }

    }
}
