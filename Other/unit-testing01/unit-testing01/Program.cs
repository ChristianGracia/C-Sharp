using System;
using System.Runtime.CompilerServices;

namespace unit_testing01
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order {DatePlaced = DateTime.now, TotalPrice = 100f};
            orderProcessor.Process(order);
        }
    }

    public class ShippingCalculator
    {
        public float CalculateShipping(OrderProcessor order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}
