using System;

namespace unit_testing01
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order has already been processed");

            order.Shipment = new Shipment(_shippingCalculator.CalculateShipping(order), DateTime.Today.AddDays(2));
        }
    }
}