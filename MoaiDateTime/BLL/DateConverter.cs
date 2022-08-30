using System;
using System.Globalization;

namespace MoaiDateTime.BLL
{
    internal static class DateConverter
    {
        internal static string ChangeGeorgianDateToStringPersianDate(DateTime DT)
        {
            PersianCalendar PerCalendar = new PersianCalendar();
            return string.Format("{0}/{1}/{2}", PerCalendar.GetYear(DT), PerCalendar.GetMonth(DT) < 10 ? "0" + PerCalendar.GetMonth(DT).ToString() : PerCalendar.GetMonth(DT).ToString(), PerCalendar.GetDayOfMonth(DT) < 10 ? "0" + PerCalendar.GetDayOfMonth(DT).ToString() : PerCalendar.GetDayOfMonth(DT).ToString());
        }

        internal static string ChangeGeorgianDateToStringHijriDate(DateTime DT)
        {
            HijriCalendar HijriCal = new HijriCalendar();
            return string.Format("{0}/{1}/{2}", HijriCal.GetYear(DT), HijriCal.GetMonth(DT) < 10 ? "0" + HijriCal.GetMonth(DT).ToString() : HijriCal.GetMonth(DT).ToString(), HijriCal.GetDayOfMonth(DT) < 10 ? "0" + HijriCal.GetDayOfMonth(DT).ToString() : HijriCal.GetDayOfMonth(DT).ToString());
        }
    }
}