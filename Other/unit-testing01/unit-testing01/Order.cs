using System;

namespace unit_testing01
{
    public class Order
    {
        public DateTime DatePlaced;
        public float TotalPrice;
        public bool IsShipped = false;
        public Shipment Shipment;
      
    }
}