using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoApp2.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(Calculator.Add(-5, 5), 0);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(Calculator.Subtract(-5, -5), 0);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(Calculator.Multiply(-5, -5), 25);
        }
    }
}