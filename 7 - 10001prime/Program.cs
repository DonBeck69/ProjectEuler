using System;

namespace _7___10001prime
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberXPrime np = new NumberXPrime();
            long[] primes = np.GetPrimeNumbers(10001);
            long prime = primes[primes.Length - 1]; 
            Console.WriteLine($"Prime number is {prime}");
        }
    }

    public class NumberXPrime
    {
        public long[] GetPrimeNumbers(int Max)
        {
            long[] primes = new long[] { 2 };
            long prime = 3;
            while(primes.Length <= Max - 1)
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

                ++prime;
            }


            return primes;
        }

    }
}
