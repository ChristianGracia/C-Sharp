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

            //get capacity
            Console.WriteLine("\ncount is " + hash.Count + "\n");

            //remove a value
            hash.Remove("panda");
            hash.Remove("pandaa");
            hash.Remove("pandaaa");

            Console.WriteLine("after panda removal\n");

            //display removed
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //checking if item is in hash table
            if (hash.Contains("dog"))
            {
                Console.WriteLine("\ndog found");
                Console.WriteLine("dog removed");
            }

            hash.Remove("dog");
            
            if(!hash.Contains("dog"))
                Console.WriteLine("dog not here :(");

            //copy to ArrayList
            //can copy keys or values

            ArrayList array = new ArrayList(hash.Keys);

            Console.WriteLine("\narray contains: \n");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


    
        }
    }

 
}
