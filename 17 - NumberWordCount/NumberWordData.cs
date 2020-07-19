using System;
using System.Collections.Generic;

namespace NumberWordCount
{
    public class NumberWordData
    {
        private Dictionary<int, string> _numberMap;
        public NumberWordData()
        {
            _numberMap = new Dictionary<int, string>();
            _numberMap.Add(0, "");
            _numberMap.Add(1, "One");
            _numberMap.Add(2, "Two");
            _numberMap.Add(3, "Three");
            _numberMap.Add(4, "Four");
            _numberMap.Add(5, "Five");
            _numberMap.Add(6, "Six");
            _numberMap.Add(7, "Seven");
            _numberMap.Add(8, "Eight");
            _numberMap.Add(9, "Nine");
            _numberMap.Add(10, "Ten");

            _numberMap.Add(11, "Eleven");
            _numberMap.Add(12, "Twelve");
            _numberMap.Add(13, "Thirteen");
            _numberMap.Add(14, "fourteen");
            _numberMap.Add(15, "fifteen");
            _numberMap.Add(16, "Sixteen");
            _numberMap.Add(17, "Seventeen");
            _numberMap.Add(18, "Eighteen");
            _numberMap.Add(19, "Nineteen");

            _numberMap.Add(20, "Twenty");
            _numberMap.Add(30, "Thirty");
            _numberMap.Add(40, "Forty");
            _numberMap.Add(50, "Fifty");
            _numberMap.Add(60, "Sixty");
            _numberMap.Add(70, "Seventy");
            _numberMap.Add(80, "Eighty");
            _numberMap.Add(90, "Ninety");

            _numberMap.Add(100, "Hundred");
            _numberMap.Add(1000, "Thousand");
            _numberMap.Add(1000000, "Million");


        }
        public Dictionary<int, string> NumberMap 
        {
            get => _numberMap;
            
            set
            {
                _numberMap = value;
            }
        }
    }
}