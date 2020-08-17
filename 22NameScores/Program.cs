using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Solutions;

namespace _22NameScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = File.ReadAllText("./names.txt");
            names = names.Replace("\"", "");
            List<string> namesList = names.Split(',').ToList();
            namesList.Sort();

            NameScores nameScores = new NameScores();
            long score = nameScores.CalculateNameScore(namesList);

            Console.WriteLine($"Score is {score}");

        }
    }
}
