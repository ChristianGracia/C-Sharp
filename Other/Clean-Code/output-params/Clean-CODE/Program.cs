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

    public class GetCustomersResult
    {
        public IEnumerable<Customer> Item1 { get; set; }
        public int Item2 { get; set; }
    }

    public class OutputParams
    {
        public void DisplayCustomers()
        {
            int totalCount = 0;
            var tuple = GetCustomers(1);
            totalCount =  tuple.Item2;
            var customers = tuple.Item1;
            Console.WriteLine("total customers " + totalCount);

            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }

        public GetCustomersResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomersResult() {Item1 = new List<Customer>(), Item2 = totalCount};
        }
    }
}
