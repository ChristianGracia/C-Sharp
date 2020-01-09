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
        }

        public static string StringUppercaser(string input)
        {
            return input.ToUpper();
        }
    }
}
