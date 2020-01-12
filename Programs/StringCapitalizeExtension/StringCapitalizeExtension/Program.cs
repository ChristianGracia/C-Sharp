using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace StringCapitalizeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hiii whats up";
            Console.WriteLine(text.CapitalizeLetters());
        }
    }

    static class CustomExtension
    {
        public static string CapitalizeLetters(this string text)
        {
            string[] words = text.Split(" ");

            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);

            }

            return string.Join(" ", words);
        }
    }
}
