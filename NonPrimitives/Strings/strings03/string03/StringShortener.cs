using System;
using System.Collections.Generic;
using System.Text;

namespace string03
{
    public class StringShortener
    {
        public static string SummarizeText(string text)
        {

            const int maxLength = 20;

            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
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
            return summary;

        }
    }
}
