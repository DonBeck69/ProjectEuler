using System;

namespace NumberWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            WordsGenerator wg = new WordsGenerator();

            
            int num = 115;
            string singleWord = wg.GetNumberAsWord(num);
            Console.WriteLine($"The number {num} is {singleWord}");
            long count = wg.LetterInStringCount(singleWord);
            Console.WriteLine($"The number of letters is {count}");
            
            string[] words = wg.GetNumbersAsWordsRange(1, 1001);

            long count2 = wg.LetterInStringArrayCount(words);
            Console.WriteLine($"The number of letters is {count2}");

            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
