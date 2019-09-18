using System;

namespace unit_testing01
{
    public class Shipment
    {
        public int Cost;
        public DateTime ShippingDate;
        public Shipment(int cost, DateTime shippingDate)
        {
            this.Cost = cost;
            this.ShippingDate = shippingDate;

        }

    }
}