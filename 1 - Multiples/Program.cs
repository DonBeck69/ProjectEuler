using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            NaturalNumbersCalc naturalNumbersCalc = new NaturalNumbersCalc();
            //int totalThree = naturalNumbersCalc.CalcMultipleTotals(1000, 3);
            //int totalFive = naturalNumbersCalc.CalcMultipleTotals(1000, 5);
            //Console.WriteLine($"Result is {totalThree}");
            //Console.WriteLine($"Result is {totalFive}");



            int result = naturalNumbersCalc.CalcSumOfMultiples(0, 1000, new int[] { 3, 5 });

            Console.WriteLine($"Result is {result}");
        }


    }

    public class NaturalNumbersCalc
    {
        public int CalcSumOfMultiples(int Min, int Max, int[] MultiplesOf)
        {
            int calculatedValue = 0;
            if (Min < 0)
            {
                Min = 0; // to avoind / 0 errors ;=)
                Console.WriteLine("Min canot be negetive, Min set to 0");
            }

            if (Min == 0)
            {
                ++Min; // divide by zero
            }

            if (Max <= Min)
            {
                Console.WriteLine("Max needs to be larger than Min... Cm'on!");
                return -1;
            }

            //int calcTotal = 0;

            int[] excludeList = new int[0];

            for (int index = 0; index <= MultiplesOf.Length - 1; index++)
            {
                // get other multiplesOf
                int multipleTotal = 0;
                //int nextMultiple = 0; //MultiplesOf[index];
                int multipleOf = MultiplesOf[index];
                for (int count = 1; count < Max; count++)
                {
                    int multiple = multipleOf * count;
                    if (multiple < Max)
                    {
                        bool AddMultiple = true;
                        // check for duplicates
                        if (index > 0)
                        {
                            // Get a multiples array of processed multiples
                            int[] checkMultiplesOf = new int[index];
                            for (int check = 0; check < index; check++)
                            {
                                checkMultiplesOf[check] = MultiplesOf[check];
                            }

                            // loop processed multiples and check against current --> get float of multiples
                            for (int checkM = 0; checkM < checkMultiplesOf.Length; checkM++)
                            {
                                //double multipleF = Convert.ToDouble(multiple);
                                if ((Convert.ToSingle(multiple) / Convert.ToSingle(checkMultiplesOf[checkM])) % 1 == 0)
                                {
                                    AddMultiple = false;
                                }
                            }
                        }

                        if(AddMultiple)
                        {
                            multipleTotal += multiple;
                        }
                        //multiList.Add(Multiple * count);
                        //Console.WriteLine($"multiple is {multipleOf * count}");
                    }
                    else
                    {
                        break;
                    }
                }

                calculatedValue += multipleTotal;

            }

            return calculatedValue;

        }

        public void CheckDuplicateMultiples(int[] ExcludeList, int[] Multiples, int Count)
        {

        }

        public int CalcMultipleTotals(int Max, int Multiple)
        {
            List<int> multiList = new List<int>();
            //int multipleTot = 0;
            //multiList.Add(multiple);
            for (int count = 0; count < Max; count++)
            {
                if (Multiple * count < Max)
                {
                    //multipleTot += Multiple * count;
                    multiList.Add(Multiple * count);
                    Console.WriteLine($"multiple is {Multiple * count}");
                }
                else
                {
                    break;
                }
            }
            return multiList.Sum();
        }

        public bool CheckIfNaturalNumber(decimal Number)
        {
            return Number % 1 == 0;
        }
    }
}
