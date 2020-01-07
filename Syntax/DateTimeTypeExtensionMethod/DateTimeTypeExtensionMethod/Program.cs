using System;

namespace DateTimeTypeExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2020,1,5);
            Console.WriteLine(date.FormatString());
            Console.WriteLine(date.FormatStringDif());
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
            public static string FormatStringDif(this DateTime date)
            {
                return string.Format("{0:dddd dd\nMMMM yyyy}", date);
            }
    }
    
}
