using System;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            // boxing causes performance penalty because of extra object creation
            // use type safety data containers such as <List><>

            // boxing - converting value type instance to an object reference
            // store on heap

            int number = 10;
            ;
            object obj = number;

            // or

            object obj = 10;

            //unboxing converts from object type back to value

            object obj = 10;
            int number = (int) obj;


        }
    }
}
