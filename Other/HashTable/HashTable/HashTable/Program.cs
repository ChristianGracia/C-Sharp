using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable01
{
    class Program
    {
        static void Main(string[] args)
        {
            //create hashtable
            //init with object
            Hashtable hash = new Hashtable
            {
                {"dog", "1"},
                {"snake", "2"},
                {"panda", "3"},
                {"pandaa", "12"},
                {"pandaaa", "13"},
                {"cat", "4"},
                {"bird", "5"},
                {"wizard", "6"},
                {"bat", "7"},
                {"skelly", "8"}
            };

            //or add items with Add method
            hash.Add("elf","9");
            hash.Add("villain", "10");
            hash.Add("bane", "11");

            //display
            //need type DictionaryEntry
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }

 
}
