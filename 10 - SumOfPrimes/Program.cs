using System;

namespace _10___SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            SummPrimes sp = new SummPrimes();
            long total = sp.GetSumOfPrimes(2000000);
            Console.WriteLine($"Sum Of Primes below 2000000 is {total}");
        }
    }

    public class SummPrimes
    {
        public long GetSumOfPrimes(int Max)
        {
            double primeTotal = 2;
            double prime = 3;
            double maxPrime = prime;
            Max -= 1;
            while (prime <= Max)
            {
                //
                if (prime % 2 != 0)
                {
                    //add all odd numbers below 9
                    if (prime > 9)
                    {
                        int rootPrime = Convert.ToInt32(Math.Ceiling(Math.Sqrt(prime)));
                        bool IsPrime = true; 
                        // less than square root, odd numbers 
                        for (int check = 3; check <= rootPrime; check += 2)
                        {
                            if (prime % check == 0)
                            {
                                IsPrime = false;
                                break;
                            }
                        }

                        if (IsPrime)
                        {
                            maxPrime = prime;
                            primeTotal += prime;
                        }
                    }
                    else
                    {
                        if (prime < 9)
                        {
                            maxPrime = prime;
                            primeTotal += prime;
                        }
                    }
                }

                ++prime;
            }

            Console.WriteLine($"Prime {maxPrime}");
            long retVal = Convert.ToInt64(primeTotal);
            return retVal;
        }


    }
}
