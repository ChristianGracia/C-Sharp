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
    
            //SIMPLIFYING TRUE/FALSE/////////////////////////////////////////////////////////

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
            isGoldCustomer = customer.TotalOrders > 50;

            //COMBINING///////////////////////////////////////////////////////////

            //before combine

            if (a)
            {
                if (b)
                {
                    //logic
                }
            }

            //after combine
            if (a && b)
            {
                //logic

            }

            //EARLY EXIT//////////////////////////////////////////////////////////////






            //COMBING EARLY EXIT AND COMBINE//////////////////////////////////////////////

            //before simplification

            if (a)
            {
                if (b)
                {
                    //logic, if we get here, both a and b are true
                }
            }

            //with simplification
            if (!a || !b)
                return something;
            // else logic

        }
    }
}
