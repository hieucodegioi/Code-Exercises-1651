using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    internal class DateModifier
    {
        private DateTime ParseDate(string dateString)
        {
            DateTime date;
            while (!DateTime.TryParse(dateString, out date))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (e.g., yyyy-mm-dd):");
                dateString = Console.ReadLine();
            }

            return date;
        }
        public int CalculateDateDifference(string firstDate, string secondDate)
        {
            DateTime date1 = ParseDate(firstDate);
            DateTime date2 = ParseDate(secondDate);

            TimeSpan difference = date1 - date2;
            int dayDifference = Math.Abs(difference.Days);

            return dayDifference;
        }
    }
}
