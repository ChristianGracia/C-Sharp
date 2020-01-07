using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            Console.WriteLine(x.IsGreater(10));
            string text = "hi";
            Console.WriteLine(text.IsNumber());
        }
    }

    static class CustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int results);
        }
    }
}
