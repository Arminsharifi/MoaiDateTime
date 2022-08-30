using NodaTime;
using System;

namespace MoaiDateTime.BLL
{
    internal static class DateTimeBLL
    {
        internal static DateTime fncGetDateFromInternet()
        {
            Instant now = NodaTime.NetworkClock.Instance.GetCurrentInstant();
            DateTimeZone tz = DateTimeZoneProviders.Tzdb["Asia/Tehran"];
            return now.InZone(tz).ToDateTimeUnspecified();
        }
    }
}