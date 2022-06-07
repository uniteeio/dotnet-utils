using System;

namespace Unitee.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetPreviousDay(this DateTime dt, DayOfWeek startOfWeek)
        {
            var diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
        
        public static DateTime GetNextDay(this DateTime dt, DayOfWeek endOfWeek)
        {
            var diff = (7 + (endOfWeek - dt.DayOfWeek)) % 7;
            return dt.AddDays(diff).Date;
        }
    }
}