using System;
using System.Collections.Generic;


namespace NumberWordCount
{
    public class WordsGenerator
    {
        public string[] GetNumbersAsWordsRange(int Min, int Max)
        {
            string[] words = new string[Max - 1];
            NumberWordData wordData = new NumberWordData();

            Dictionary<int, string> numberMap = wordData.NumberMap;

            for (int count = Min; count <= Max - 1; count++)
            {
                string word = BuildWord(count, wordData.NumberMap);
                words[count - 1] = word;
            }

            return words;

        }

        public string GetNumberAsWord(int Number)
        {
            NumberWordData wordData = new NumberWordData();

            string word = BuildWord(Number, wordData.NumberMap);

            return word;
        }

        public long LetterInStringArrayCount(String[] Words)
        {
            long letters = 0;
            foreach(string word in Words)
            {
                letters += this.LetterInStringCount(word);
            }
            return letters;
        }

        public long LetterInStringCount(String Word)
        {
            long letters = 0;
            Word = Word.Replace(" ", string.Empty);
            Word = Word.Replace("-", string.Empty);
            letters = Word.Length;
            return letters;
        }


        public string BuildWord(int Number, Dictionary<int, string> NumberMap)
        {
            short[] units = NumberToArray(Number);
            int teen = 0;
            if (Number > 9)
            {
                int[] teenArray = new int[] { units[1], units[0] };
                teen = ArrayToNumber(teenArray);
            }
            string word = string.Empty;
            for (int count = 0; count <= units.Length - 1; count++)
            {
                switch (count)
                {
                    case 0:
                        word = NumberMap[units[count]];
                        break;
                    case 1:
                        int tens = units[count] * 10;
                        if (teen < 20)
                        {
                            word = $"{NumberMap[teen]}";
                        }
                        else if (word.Length == 0 && tens > 0)
                        {
                            word = $"{NumberMap[tens]}";

                        }
                        else if (word.Length > 0 && tens > 0)
                        {
                            word = $"{NumberMap[tens]}-{word}";
                        }
                        break;
                    case 2:
                        int hundreds = units[count] * 100;
                        if (units[count] > 0 && word.Length > 0)
                        {
                            word = $"{NumberMap[units[count]]} {NumberMap[100]} and {word}";
                        }
                        else if (units[count] > 0 && word.Length == 0)
                        {
                            word = $"{NumberMap[units[count]]} {NumberMap[100]}";
                        }
                        else if (units[count] == 0 && word.Length > 0)
                        {
                            word = $" and {word}";
                        }
                        break;
                    case 3:
                        if (units[count] > 0)
                        {
                            word = $"{NumberMap[units[count]]} {NumberMap[1000]} {word}";
                        }
                        break;
                    case 4:
                        if (units[count] > 0)
                        {
                            int tenThou = units[count] * 10;
                            word = $"{NumberMap[tenThou]} {word}";
                        }
                        break;
                    case 5:
                        word = $"{NumberMap[units[count]]} {NumberMap[100]} {word}";
                        break;
                }
            }

            return word;

        }

        public short[] NumberToArray(int Number)
        {
            short[] digits = new short[0];
            //Console.WriteLine(Number.ToString());
            int count = 0;
            while (Number != 0)
            {
                short diget = (short)(Number % 10);
                //Console.WriteLine(diget.ToString());
                Number = Number / 10;
                //Console.WriteLine(Number.ToString());
                Array.Resize(ref digits, digits.Length + 1);
                digits[digits.Length - 1] = diget;
                count++;

            }

            //Console.WriteLine($"count {count}");
            return digits;
        }

        public int ArrayToNumber(int[] NumberArray)
        {
            int result = 0;
            int digitCount = 1;
            for (int index = NumberArray.Length - 1; index >= 0; index--)
            {
                result += NumberArray[index] * digitCount;
                digitCount *= 10;
            }

            return result;
        }


    }
}