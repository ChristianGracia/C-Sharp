﻿using System;

namespace unit_testing01
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }

        public Shipment Shipment { get; set; }

        public bool IsShipped => Shipment != null;


        public Order(DateTime DatePlaced, float TotalPrice)
        {
            this.DatePlaced = DatePlaced;
            this.TotalPrice = TotalPrice;
        }
    }
}