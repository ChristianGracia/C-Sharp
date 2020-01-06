using System;

namespace DateTimeTypeExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.FormatString());
        }
    }

    static class DateTimeExtension
        {
            public static string FormatString(this DateTime date)
            {
                string formattedString = date.DayOfWeek.ToString() + " " + date.Day.ToString() + "\n" +
                                         date.Month.ToString() + " " + date.Year.ToString();

                return formattedString;
            }
    }
    
}
