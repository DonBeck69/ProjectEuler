using System;
using System.Collections.Generic;
using Solutions;

namespace _19___CountSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcSundays calcSundays = new CalcSundays();

            int suns = calcSundays.GetSundayCount(1901, 2000);
            Console.WriteLine($"Number of Sundays on the 1st is... {suns}");
        }
    }

    public class CalcSundays
    {
        public int GetSundayCount(int StartYear, int EndYear)
        {

            // get the day for the 1st day of the start year
            DateTime firstDay = new DateTime(StartYear, 1, 1);
            
            int suns = 0;

            MonthData md = new MonthData();
            Dictionary<string, int> months = md.DaysInMonths;
            Dictionary<string, int> monthAndNumber = md.MonthAndNumber;
            //Dictionary<string, int> dayAndDate = new Dictionary<string, int>();
            for (int year = StartYear; year <= EndYear; year++)
            {
                Console.WriteLine($"Year {year}");

                foreach (KeyValuePair<string, int> month in months)
                {
                    int days = month.Value;
                    if (month.Key == "Feb" && md.IsLeapYear(year))
                    {
                        ++days;
                    }

                    for (int day = 1; day <= days; day++)
                    {
                        DateTime date = new DateTime(year, monthAndNumber[month.Key], day);
                        //dayAndDate.Add(date.DayOfWeek.ToString(), day);
                        if (day == 1 && date.DayOfWeek == DayOfWeek.Sunday)
                        {
                            suns++;
                        }

                    }

                }
            }

            return suns;
        }
    }
}
