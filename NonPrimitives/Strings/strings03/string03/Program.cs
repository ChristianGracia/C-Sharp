using System;
using System.Collections.Generic;

namespace string03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "really really really really really really long text im gonna shorten";
            const int maxLength = 20;

            if(sentence.Length < maxLength)
            Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }
                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);

            }
        }

    }
}
