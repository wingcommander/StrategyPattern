using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CostCalculationService_WithStrategy costCalculation = new CostCalculationService_WithStrategy(new FedexShippingStrategy());
            Assert.AreEqual(costCalculation.CalculateShippingCost(new Order()),5.0);

        }


        [TestMethod]
        public void TestMethod2()
        {
            Func<Order, double> upsStrategy = delegate(Order order) { return 4.00d; };
            Func<Order, double> fedexStrategy = delegate(Order order) { return 5.00d; };
            Func<Order, double> schenkerStrategy = delegate(Order order) { return 3.00d; };

            ShippingCostCalculatorService csc = new ShippingCostCalculatorService();
            Assert.AreEqual(csc.CalculateShippingCost(new Order(), upsStrategy), 4.00);
            Assert.AreEqual(csc.CalculateShippingCost(new Order(), fedexStrategy), 5.00);

        }
       
    }
}
