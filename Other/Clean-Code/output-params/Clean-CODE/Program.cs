using System;
using System.Collections;
using System.Collections.Generic;

namespace Clean_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //avoid output params
            //return an object from a method instead
     
        }
    }

    public class GetCustomersResult
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
    
    public class OutputParams
    {
        public void DisplayCustomers()
        {
            const int pageIndex = 1;
            var result = GetCustomers(pageIndex);
            Console.WriteLine("total customers " + result.TotalCount);

            foreach (var c in result.Customers)
            {
                Console.WriteLine(c);
            }
        }

        public GetCustomersResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomersResult() {Customers = new List<Customer>(), Item2 = totalCount};
        }
    }
}
