using System;
using System.Linq;

namespace ArrayReverser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name to be reversed");
            var name = Console.ReadLine();
            var length = name.Length;
            Console.WriteLine(name.Length);

            var array = new char[length];

            for (var i = 0; i < length; i++)
            {
                array[i] = name[i];
            }

            Array.Reverse(array);

            var reverse = array.Aggregate("", (current, item) => current + (char) item);

            Console.WriteLine(reverse);
        }
    }
}