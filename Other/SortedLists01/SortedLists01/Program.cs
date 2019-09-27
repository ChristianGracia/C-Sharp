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
            //value can not be null or duplicate

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
            {
                Console.WriteLine(item.Key + ": " + item.Value
                                  );
            }

        }
    }
}
