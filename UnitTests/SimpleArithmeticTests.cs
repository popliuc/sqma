using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SimpleArithmeticTests
    {
        [TestMethod]
        public void TestAddition()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Addition(1, 1) == 2);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Subtraction(1, 1) == 0);
        }


    }
}