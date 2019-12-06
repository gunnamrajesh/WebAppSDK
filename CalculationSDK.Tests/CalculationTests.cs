using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculationSDK.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void SinmpleMathTest()
        {
            var calculator = new SimpleMath();

            Assert.AreEqual(30, calculator.Add(10, 20));

            Assert.AreEqual(-10, calculator.Sub(10, 20));

            Assert.AreEqual(10, calculator.AbsSub(10, 20));
        }
    }
}
