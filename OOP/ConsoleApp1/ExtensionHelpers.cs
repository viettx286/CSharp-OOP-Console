using System;

namespace ConsoleApp1
{
    public static class ExtensionHelpers
    {
        public static string ToCurrency(this double currency)
        {
            return String.Format("${0:0,0.00}", currency);
        }

        public static string ToSystemDate(this DateTime dt)
        {
            return dt.ToString("DDmmYYYY");
        }

        
    }
}