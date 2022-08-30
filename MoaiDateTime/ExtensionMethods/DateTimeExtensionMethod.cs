using MoaiDateTime.BLL;
using System;

namespace MoaiDateTime.ExtensionMethods
{
    public static class DateTimeExtensionMethod
    {
        public static string ToShamsiDateString(this DateTime dt)
        {
            return DateConverter.ChangeGeorgianDateToStringPersianDate(dt);
        }
        
        public static string ToShamsiDateAndTimeString(this DateTime dt)
        {
            return DateConverter.ChangeGeorgianDateToStringPersianDate(dt) + " - " + dt.ToShortTimeString();
        }
        
        public static string ToHijriDateString(this DateTime dt)
        {
            return DateConverter.ChangeGeorgianDateToStringPersianDate(dt);
        }
    }
}