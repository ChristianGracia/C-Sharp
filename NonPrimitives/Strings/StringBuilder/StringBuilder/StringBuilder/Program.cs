using System;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("hi whats up");

            //long chain of methods used on a StringBuilder class
            //append/insert/replace/remove

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace("-", "+")
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            //access through index
            Console.WriteLine("first char: " + builder[0]);
   


        }
    }
}
