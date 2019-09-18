using System;
namespace unit_testing01
{
    public class ShippingCalculator
    {
        public float CalculateShipping(OrderProcessor order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }

    public class Shipment
    {
        public int Cost { get; set; }
        public DateTime ShippingDate { get; set; }
        public Shipment(int cost, DateTime shippingDate)
        {
            this.Cost = cost;
            this.ShippingDate = shippingDate;

        }

    }
}