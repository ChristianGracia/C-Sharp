using System;

namespace ActionDelgates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> actionOne = DisplayMessage;
            actionOne(12);

            Action actionTwo = DisplayMessage;
            actionTwo();

        }

        public static void DisplayMessage()
        {
            Console.WriteLine("hi from method without param");

        }

        public static void DisplayMessage(int number)
        {
            Console.WriteLine("number is " + number);

        }
    }
}
