using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    public static class CustomExtensions
    {
        public static double GetSquare(this int value)
        {
            return Math.Pow(value, 2);
        }

        public static string ToTitleCase(this string value)
        {
            //türkay ürkmez
            //Türkay Ürkmez

            var wordArray = value.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                wordArray[i] = wordArray[i].Substring(0, 1).ToUpper() + wordArray[i].Substring(1).ToLower();

            }

            string output = string.Join(' ', wordArray);
            return output;
        }

        public static int TotalWorkDaysInYear(this DateTime date, List<DateTime> holidays)
        {

            var startDate = new DateTime(date.Year, 1, 1);
            var endDate = new DateTime(date.Year, 12, 31);
            int workDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if ((currentDate.DayOfWeek != DayOfWeek.Sunday) && (currentDate.DayOfWeek != DayOfWeek.Saturday))
                {
                    if (!holidays.Contains(currentDate))
                    {
                        workDays++;
                    }
                }
            }

            return workDays;
        }
    }
}
