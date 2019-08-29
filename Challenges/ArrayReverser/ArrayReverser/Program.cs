using System;

namespace ArrayReverser
{
    class Program
    {
        static void Main(string[] args)
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

            string reverse = "";

            for (var x = 0; x < array.Length; x++)
            {
                reverse += (char) array[x];

            }
    
            Console.WriteLine(reverse);
        }
    }
}
