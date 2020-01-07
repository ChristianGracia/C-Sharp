using System;

namespace fields01
{

    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());


            // deletes data so use readonly modifier
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
