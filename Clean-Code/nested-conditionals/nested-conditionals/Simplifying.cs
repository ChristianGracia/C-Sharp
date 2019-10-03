namespace nested_conditionals
{
    public class Simplifying
    {
        public void Method()
        {
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
        }

    }
}