using System;
using System.Collections;
using System.Collections.Generic;

namespace Clean_Code
{
    class Program
    {
        static void Main(string[] args)
        {
     
        }
    }

    public class OutputParams
    {
        public void DisplayCustomers()
        {
            int totalCount = 0;
            var customers = GetCustomers(1, out totalCount);
            Console.WriteLine("total customers " + totalCount);

            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }

        public Tuple<IEnumerable<Customer>, int> GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return Tuple.Create((IEnumerable<Customer>) new List<Customer>(), totalCount);
        }
    }
}
