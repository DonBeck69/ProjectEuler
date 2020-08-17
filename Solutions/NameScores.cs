using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class NameScores
    {

        //private string[] alpha = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };


    public long CalculateNameScore(List<string> Names)
        {
            long score = 0;
            foreach(string name in Names)
            {
                int worth = 0;
                foreach(char letter in name)
                {
                    worth += char.ToUpper(letter) - 64;
                }
                score += (Names.IndexOf(name) + 1) * worth;
            }
            return score;
        }
    }
}
