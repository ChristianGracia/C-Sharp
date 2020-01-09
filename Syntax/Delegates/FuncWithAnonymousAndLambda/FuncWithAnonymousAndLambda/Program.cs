using System;

namespace FuncWithAnonymousAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> convertUppercaser = StringUppercaser;
            Console.WriteLine("Using func");
            Console.WriteLine(convertUppercaser("uppercase me"));

            Func<string, string> anonymousUppercaser = delegate(string s) { return s.ToUpper(); };

            Func<string, string> lambdaUppercaser = s => s.ToUpper();
        }

        public static string StringUppercaser(string input)
        {
            return input.ToUpper();
        }
    }
}
