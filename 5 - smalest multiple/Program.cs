using System;

namespace _5___smalest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestMultiple sm = new SmallestMultiple();
            int smallest = sm.GetSmalest(20);
            Console.WriteLine($"Smallest = {smallest}");
        }

        public class SmallestMultiple
        {
            public int GetSmalest(int Max)
            {
                int smallest = Max;
                bool foundSmallest = false;
                while(foundSmallest == false)
                {
                    bool found = true;
                    for(int index = 1; index <= Max; index++)
                    {
                        if (smallest % index != 0)
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        foundSmallest = true;
                        break;
                    }
                    smallest += Max;
                }


                return smallest;
            }
        }
    }
}
