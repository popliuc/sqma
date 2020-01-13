using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
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
