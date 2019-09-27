using System;
using System.Collections;

namespace SortedLists01
{
    class Program
    {
        static void Main(string[] args)
        {
            //sorted list cna be generic or non-generic
            //generic collections are strongly typed while non generic can hold any type
            //ie generic collections store elements in arrays of their actual types
            //generic collections are faster then non generic collections when using value types and more convenient when using reference types.

            //store key value pairs in ascending order from key.
            //key can not be null or duplicate

            //create
            SortedList sortedList = new SortedList();

            //add
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "March");
            sortedList.Add(4, "April");
            sortedList.Add(5, "May");
            sortedList.Add(6, "June");

            //display
            foreach (DictionaryEntry item in sortedList)
                Console.WriteLine(item.Key + ": " + item.Value);

            //add more that will be sorted
            Console.WriteLine("\nUpdated List\n");

            //item to be added and sorted accordingly
            sortedList.Add(0, "november");

            //display list with new item to be sorted
            foreach (DictionaryEntry item in sortedList)
                Console.WriteLine(item.Key + ": " + item.Value);

            //Console.WriteLine("\nwith for loop\n");

            //display values with for loop
            for (var i = 0; i < sortedList.Count; i++)
            {
                //Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
            }

            Console.WriteLine("\nby index");
            //by index
            Console.WriteLine(sortedList[5].ToString());
            //capacity
            Console.WriteLine("\ncapacity: " + sortedList.Capacity + "\n");

            //remove
            sortedList.Remove(1);

            //check what list has by key
            Console.WriteLine(sortedList.Contains(1));

            //check what list has by value
            Console.WriteLine(sortedList.ContainsValue("Jan"));

            Console.WriteLine("\n");

            //copy to array list
            ArrayList array = new ArrayList(sortedList.Values);

            //display array
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}