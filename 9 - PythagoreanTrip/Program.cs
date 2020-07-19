using System;

namespace _9___PythagoreanTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            PythagoreanTriplet pt = new PythagoreanTriplet();
            int result = pt.getProducts(1000);
            Console.WriteLine($"Product is {result}");
        }
    }

    public class PythagoreanTriplet
    {
        public int getProducts(int ForNumber)
        {
            int result = 0;

            // now find products
            bool found = false;
            for (int left = 4; left <= ForNumber / 3; left++)
            {
                for (int right = left; right <= ForNumber / 2; right++)
                {
                    int check = ForNumber - left - right;
                    int prs = (left * left) + (right * right);
                    if (check * check == prs)
                    {
                        if (left + right + check == 1000)
                        {
                            found = true;
                            result = left * right * check;
                            break;
                        }
                    }

                }

                if (found)
                {
                    break;
                }
            }

            return result;

        }
    }
}
