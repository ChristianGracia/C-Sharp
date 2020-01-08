using System;

namespace GenericDelegates
{
    class Program
    {
        public delegate T DisplayInfo<T>(T value);
        static void Main(string[] args)
        {
            DisplayInfo<int> newNumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(newNumber(4));

            DisplayInfo<string> newString = new DisplayInfo<string>(DisplayValue);
            Console.WriteLine(newString("hi"));

            DisplayInfo<int[]> newArray = new DisplayInfo<int[]>(DisplayValue);
            Console.WriteLine(newArray(new int[3]{1, 2, 3}));

            DisplayInfo<DateTime> newDate = new DisplayInfo<DateTime>(DisplayValue);
            Console.WriteLine(newDate(DateTime.Now));

            DisplayInfo<double> newDouble = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(newDouble(100_000_000_000));
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Var type: " + value.GetType().Name);
            return value;

        }
    }
}
