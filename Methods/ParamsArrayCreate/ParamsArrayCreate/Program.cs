using System;

namespace ParamsArrayCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray(4, 23, 66);

            LoopThroughArray("chris", "joe", "jake");

            LoopThroughArray(DateTime.Now, new DateTime(2020, 1, 5));
        }

        public static void LoopThroughArray<T>(params T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
        }
    }

}
