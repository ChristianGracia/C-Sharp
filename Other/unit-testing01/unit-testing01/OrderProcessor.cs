using System;

namespace unit_testing01
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order has already been processed");

            order.Shipment = new Shipment(_shippingCalculator.CalculateShipping(order), DateTime.Today.AddDays(2))
    
        }

    }
    public class Shipment
    {
        public int Cost;
        public DateTime ShippingDate;
        public Shipment(int Cost, DateTime ShippingDate)
        {
            this.Cost = Cost;
            this.ShippingDate = ShippingDate;

        }

    }
}