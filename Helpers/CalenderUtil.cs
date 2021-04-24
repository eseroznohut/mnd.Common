using System;
using System.Globalization;

namespace mnd.Common
{
    public class CalenderUtil
    {
        public static string GetMounthName(int mounthNumber)
        {
            return new DateTime(2015, mounthNumber, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("tr"));
        }

        public static int MounthFromWeekNumber(int _year, int _week)
        {
            var calender = CultureInfo.CurrentCulture.Calendar;

            var firstDayOfWeek_date = FirstDateOfWeekISO8601(_year, _week);

            var _mounth = calender.GetMonth(firstDayOfWeek_date);

            var _isNewMounth = calender.GetMonth(firstDayOfWeek_date.AddDays(2)) != _mounth;

            if (_isNewMounth == false)
                return _mounth;
            else
                return calender.GetMonth(firstDayOfWeek_date.AddDays(7));
        }

        public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);
            return result.AddDays(-3);
        }

        public static int GetWeekNumberFromDate(DateTime tarih)
        {
            var num = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(tarih.Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return num;
        }
    }
}