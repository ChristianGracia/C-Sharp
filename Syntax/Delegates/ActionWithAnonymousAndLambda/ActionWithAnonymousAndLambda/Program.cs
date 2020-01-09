using System;

namespace ActionWithAnonymousAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> displayInfo = SaySomething;
            displayInfo("hi");
            Action<string> displayInfoAnonymous = delegate(string s) { Console.WriteLine("You inputted: " + s); };
            displayInfoAnonymous("Anonymous");

            Action<string> displayInfoLambda = s => Console.WriteLine("You inputted: " + s);
            displayInfoLambda("Lambda");

        }

        public static void SaySomething(string input)
        {
            Console.WriteLine("You inputted: " + input);

        }
    }
}
