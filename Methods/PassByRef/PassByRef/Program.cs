using System;

namespace PassByRef
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int x = 12;
            int y = 12;

            //pre change
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);

            //change
            ChangeNames(ref x,ref y);

            //post change
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);

            //changes by reference using ref

        }

        static void ChangeNames(ref int x, ref int y)
        {
            x = 9;
            y = 9;


            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
        }
    }
}
