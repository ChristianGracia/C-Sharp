using System;

namespace Arrays02
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 3, 5, 6, 7, 4 };

            // IndexOf
            var index = Array.IndexOf(numbers, 6);

            // Clear
            Array.Clear(numbers, 0, 2);

            //foreach (var x in numbers)
                //Console.WriteLine(x);

            // Copy
            int[] array2 = new int[3];
            Array.Copy(numbers, array2, 3);

          
            //foreach(var x in array2)
                //Console.WriteLine(x);

            // Sort
            Array.Sort(numbers);

            foreach(var x in numbers)
                Console.WriteLine(x);


            // Reverse

            Array.Reverse(numbers);

            foreach(var x in numbers)
                Console.WriteLine(x);
        }
    }
}
