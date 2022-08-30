using MoaiDateTime.BLL;
using System;

namespace MoaiDateTime
{
    public static class Moai
    {
        public static DateTime GetTehranDateTime()
        {
            return DateTimeBLL.GetDateFromInternet();
        }
    }
}