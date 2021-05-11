using System;
using UtilitiesGeneral.Constants;

namespace UtilitiesGeneral.Utilities
{
    public class TimeUtil
    {
        public static int HoursToSeconds(int hours)
        {
            return hours * TimeConstants.MinutesInHour * TimeConstants.SecondsInMinute;
        }

        public static DateTime GetNextDayOfWeekDateTime(DateTime start, DayOfWeek dayOfWeek, double timeSeconds)
        {
            var date = GetNextDayOfWeek(start, dayOfWeek);

            return new DateTime(date.Year, date.Month, date.Day)
                .AddSeconds(timeSeconds);
        }

        public static DateTime GetNextDayOfWeek(DateTime start, DayOfWeek day)
        {
            if (start.DayOfWeek == day)
            {
                return start;
            }

            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;

            return start.AddDays(daysToAdd);
        }
    }
}
