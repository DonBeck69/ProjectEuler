using System;

namespace _3___Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactors primeFactors = new PrimeFactors();

            long[] pfs = primeFactors.primeFactors(600851475143);

        }
    }

    public class PrimeFactors
    {

        // get prime factors
        public long[] primeFactors(long Max)
        {
            long[] primeFactors = new long[0];
            // divide max by 2 untill there is no remainder (even number) 
            while (Max % 2 == 0)
            {
                Array.Resize(ref primeFactors, primeFactors.Length + 1);
                primeFactors[primeFactors.Length - 1] = 2;
                Max /= 2;
            }

            // now start check at 3, increase by 2. must be less than the square root of Max
            for (long check = 3; check <= Math.Sqrt(Max); check += 2)
            {
                // 
                while (Max % check == 0)
                {
                    Array.Resize(ref primeFactors, primeFactors.Length + 1);
                    primeFactors[primeFactors.Length - 1] = check;
                    Max /= check;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (Max > 2)
            {
                Array.Resize(ref primeFactors, primeFactors.Length + 1);
                primeFactors[primeFactors.Length - 1] = Max;
            }

            return primeFactors;
        }
        public int[] GetPrimeNumbers(int Max)
        {
            int[] primes = new int[] { 2 };
            for (int prime = 1; prime <= Max; prime++)
            {
                bool found = false;
                for (int check = 2; check <= prime / 2; check++)
                {
                    if (prime % check == 0)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found && prime > 1)
                {
                    Array.Resize(ref primes, primes.Length + 1);
                    primes[primes.Length - 1] = prime;
                    Console.WriteLine($"Prime number is {prime}");
                }

            }


            return primes;
        }


    }
}
