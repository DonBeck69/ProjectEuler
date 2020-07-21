using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class StringArrayToIntArray
    {
        public int[] ToIntArray(string[] strings)
        {
            int[] ints = new int[strings.Length];
            for(int index = 0; index <= strings.Length - 1; index++)
            {
                int number;
                if (int.TryParse(strings[index], out number))
                {
                    ints[index] = number;
                }
            }

            return ints;
        }
    }
}
