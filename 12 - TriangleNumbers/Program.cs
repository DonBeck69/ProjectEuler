using System;

namespace _12___TriangleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleNumbers tn = new TriangleNumbers();
            long tnumber = tn.GetTNumberbyNumberOfDivisors(501);
            Console.WriteLine($"T Number is {tnumber}");
        }
    }

    public class TriangleNumbers
    {
        public long GetTNumberbyNumberOfDivisors(int divisor)
        {
            long tNumber = 0;
            int factors = 0;
            long count = 1;
            //int[] numbers = new int[] { 1 };
            while ( factors <= divisor )
            {
                tNumber += count;
                // get number of factors
                factors = this.GetNumberOfDivisors(tNumber);
                count++;
            }

            return tNumber;
        }

        public int GetNumberOfDivisors(long Tnumber)
        {
            int divisorCount = 0;
            double sqirt = Math.Sqrt(Tnumber);
            for (int count = 1; count <= sqirt; count++)
            {
                if (Tnumber % count == 0) 
                {
                    if (Tnumber / count == count)
                    {
                        divisorCount++;
                    }
                    else{
                        divisorCount += 2;
                    }
                }
            }
            return divisorCount;

        }
    }
}
