using System;

namespace AnonymousMethods
{
    class Program
    {
        delegate void DisplayInfo();
        delegate void DisplayInfoBasedOnNumber(int number);
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();
            //without new delegate ctor
            DisplayInfoBasedOnNumber oneParameterDelegate = GetInformation;
            oneParameterDelegate(200);

            Console.WriteLine("---------------------");

            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("hi from anonymous method" ); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumber oneParameterDelegateAnonymous = delegate (int number) { Console.WriteLine($"hi from anonymous int i = {number}"); };
            oneParameterDelegateAnonymous(100_000);
        }
        public static void GetInformation()
        {
            Console.WriteLine("Delegate with no param");
        }

        public static void GetInformation(int x)
        {
            Console.WriteLine("Delegate with one param");

        }
    }


}
