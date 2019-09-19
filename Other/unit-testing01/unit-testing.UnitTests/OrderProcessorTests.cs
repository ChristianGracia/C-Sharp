using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unit_testing01.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor();
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
