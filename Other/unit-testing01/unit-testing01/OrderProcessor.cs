using System;

namespace unit_testing01
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order has already been processed");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order);
                ShippingDate = DateTime.Today.AddDays(2);
            }
        }
    }
}