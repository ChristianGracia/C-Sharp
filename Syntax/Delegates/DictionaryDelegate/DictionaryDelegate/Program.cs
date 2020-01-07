using System;
using System.Collections.Generic;

namespace DictionaryDelegate
{
    class Program
    {
        public delegate void DictionaryDisplayDelegate(Dictionary<int, string> dictionary);

        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "hi");
            dict.Add(8, "whats");
            dict.Add(11, "sup");
            DictionaryDisplayDelegate dictionaryContent = new DictionaryDisplayDelegate(DisplayEntries);
            dictionaryContent(dict);

        }

        public static void DisplayEntries(Dictionary<int, string> dictionary)
        {

            foreach (KeyValuePair<int,string> entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} {entry.Value}");
            }
            
        }

    }
}
