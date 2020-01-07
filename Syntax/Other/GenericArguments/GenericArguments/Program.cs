using System;

namespace GenericArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo("Logger logged");
            DisplayInfo(7);
            DisplayInfo(7.888888888888);
            DisplayInfo(DateTime.Now);

            var info = (7, "Chris", 12);

            DisplayInfo(info);
        }

        public static void DisplayInfo<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}
