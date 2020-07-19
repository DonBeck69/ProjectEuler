using System;

namespace MaxPathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleData td = new TriangleData();
            int[][] triangle = td.Triangle;

            // go up the triangle from 2nd from base to tip
            for (int hindex = triangle.Length - 2; hindex >= 0; hindex--)
            {
                int [] row = triangle[hindex];
                for (int vindex = 0; vindex <= row.Length - 1; vindex++)
                {
                    if (triangle[hindex][vindex] + triangle[hindex + 1][vindex] > triangle[hindex][vindex] + triangle[hindex + 1][vindex + 1])
                    {
                        triangle[hindex][vindex] = triangle[hindex][vindex] + triangle[hindex + 1][vindex];
                    }
                    else
                    {
                        triangle[hindex][vindex] = triangle[hindex][vindex] + triangle[hindex + 1][vindex + 1];
                    }
                }
            }

            Console.WriteLine($"The answer is... {triangle[0][0]}");
        }
    }
}
