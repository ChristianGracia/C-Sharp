using System;

namespace constructors02
{
    class Program
    {
   
        static void Main(string[] args)
        {
            var customer = new Customer(1, "john");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

    


        }
    }
}
