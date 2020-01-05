using System;

namespace unit_testing01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order(DateTime.Now, 100f);
            orderProcessor.Process(order);
            
        }
    }
}
