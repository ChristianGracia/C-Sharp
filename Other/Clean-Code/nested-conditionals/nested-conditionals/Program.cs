using System;

namespace nested_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
    
            //conditional
            //if (a)
                //c = 10;
            //else
            //{
               //c = 20;
            //}
            //with ternary
            //c = (a) ? someValue : anotherValue;

            //returning values with ternary

            //return (customer.TotalOrders > 50) ? 0.1f : 0.01f

            //do not use multiple ternaries if you want code readable and manageable 


            //simplifying true/false

            if (a)
                b = true;
            else
            {
                b = false;
            }

            //can assume b = a

            //ex
            if (customer.TotalOrders > 50)
                isGoldCustomer = true;
            else
            {
                isGoldCustomer = false;
            }

            //could be rewritten as
            isGoldCustomer = customer.TotalOrders > 50



        }
    }
}
