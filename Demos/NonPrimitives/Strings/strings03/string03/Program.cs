using System;
using System.Collections.Generic;

namespace string03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence= "really really really really really really long text im gonna shorten";
            var summary = StringShortener.SummarizeText(sentence);
            Console.WriteLine(summary);
        }
    }
}
