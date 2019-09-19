using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unit_testing01.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(OrderProcessorTests order)
        {
            throw new NotImplementedException();
        }
    }
}
