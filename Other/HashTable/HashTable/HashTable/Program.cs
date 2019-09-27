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
                {"a", "1"}, {"a", "1"}, {"a", "1"}, {"a", "1"},
                {"a", "1"},
                {"a", "1"},
                {"a", "1"},
                {"a", "1"},
                {"a", "1"}
            };

            //or add items with Add method
            hash.Add("a","1");
            hash.Add("a", "1");
            hash.Add("a", "1");
        }
    }

 
}
