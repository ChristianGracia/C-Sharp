using System;

namespace unit_testing01
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    //acts similar to inheritance but very different
    //inheritance reuses code, had to manually type out
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}
