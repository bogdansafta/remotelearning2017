using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void AddEmptyString()
        {
            Assert.AreEqual(0, new Calculator().Add(""));
        }
    }
}
