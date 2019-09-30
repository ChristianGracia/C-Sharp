using System;

namespace nested_conditionals
{
    public class SwapOrders
    {
        public void Method()
        {
            //SWAP ORDERS/////////////////////////////////////////////////////////////////


            //original
            if (a)
            {
                if (b)
                {
                    isValid = true;

                }
            }

            if (c)
            {
                if (b)
                {
                    isValid = true;
                }
            }

            //simplified to 3 conditionals

            if (b)
            {
                if (a)
                    isValid = true;
                if (c)
                    isValid = true;
            }

            //then combine

            if (b)
            {
                if (a || c)
                    isValid = true;
            }

            //then apply combine technique again

            if (b && (a || c))
                isValid = true;

            //even more simplified

            isValid = (b && (a || c));

            //use moderation, dont make code unreadable

        }
    }
}