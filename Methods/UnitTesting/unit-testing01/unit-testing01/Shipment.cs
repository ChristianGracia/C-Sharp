using System;

namespace unit_testing01
{
    public class Shipment
    {
        public float Cost;
        public DateTime ShippingDate;
        public Shipment(float cost, DateTime shippingDate)
        {
            this.Cost = cost;
            this.ShippingDate = shippingDate;

        }

    }
}