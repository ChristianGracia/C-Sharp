using System;

namespace unit_testing01
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped = false;
        public Shipment Shipment;
        public Order(DateTime DatePlaced, float TotalPrice)
        {
            this.DatePlaced = DatePlaced;
            this.TotalPrice = TotalPrice;
            this.IsShipped = true;

        }
    }
}