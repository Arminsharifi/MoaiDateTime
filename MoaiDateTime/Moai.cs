using MoaiDateTime.BLL;
using System;

namespace MoaiDateTime
{
    public static class Moai
    {
        public static DateTime GetDateTime()
        {
            return DateTimeBLL.GetDateFromInternet();
        }

        public static DateTime ConvertPersianDateToGeorgianDate(string PersianDate)
        {
            return DateConverter.ChangePersianDateToGeorgianDate(PersianDate);
        }

        public static DateTime ConvertHijriDateToGeorgianDate(string HijriDate)
        {
            return DateConverter.ChangePersianDateToGeorgianDate(HijriDate);
        }
    }
}