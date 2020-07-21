using System;

namespace Solutions
{
    public class MaxPath
    {
        public int CalculateMax(int[][] triangle)
        {
            // go up the triangle from 2nd from base to tip
            for (int hindex = triangle.Length - 2; hindex >= 0; hindex--)
            {
                int[] row = triangle[hindex];
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

            return triangle[0][0];

            //Console.WriteLine($"The answer is... {triangle[0][0]}");
        }
    }
}
