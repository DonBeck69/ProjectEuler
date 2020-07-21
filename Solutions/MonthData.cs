using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{

    public class MonthData
    {
        private Dictionary<string, int> _dyasInMonths;
        private Dictionary<string, int> _monthAndNumber;

        public MonthData()
        {
            _dyasInMonths = new Dictionary<string, int>();
            _dyasInMonths.Add("Jan", 31);
            _dyasInMonths.Add("Feb", 28);
            _dyasInMonths.Add("Mar", 31);
            _dyasInMonths.Add("Apr", 30);
            _dyasInMonths.Add("May", 31);
            _dyasInMonths.Add("Jun", 30);
            _dyasInMonths.Add("Jul", 31);
            _dyasInMonths.Add("Aug", 31);
            _dyasInMonths.Add("Sep", 30);
            _dyasInMonths.Add("Oct", 31);
            _dyasInMonths.Add("Nov", 30);
            _dyasInMonths.Add("Dec", 31);

            _monthAndNumber = new Dictionary<string, int>();
            _monthAndNumber.Add("Jan", 1);
            _monthAndNumber.Add("Feb", 2);
            _monthAndNumber.Add("Mar", 3);
            _monthAndNumber.Add("Apr", 4);
            _monthAndNumber.Add("May", 5);
            _monthAndNumber.Add("Jun", 6);
            _monthAndNumber.Add("Jul", 7);
            _monthAndNumber.Add("Aug", 8);
            _monthAndNumber.Add("Sep", 9);
            _monthAndNumber.Add("Oct", 10);
            _monthAndNumber.Add("Nov", 11);
            _monthAndNumber.Add("Dec", 12);

        }

        public Dictionary<string, int> DaysInMonths
        {
            get => _dyasInMonths;
        }


        public Dictionary<string, int> MonthAndNumber
        {
            get => _monthAndNumber;
        }

        public bool IsLeapYear(int Year)
        {
            bool leap = false;
            if (Year % 1000 == 0 && Year % 400 == 0)
            {
                leap = true;
            }
            else if (Year % 4 == 0)
            {
                leap = true;
            }

            return leap;

        }

    }
}
