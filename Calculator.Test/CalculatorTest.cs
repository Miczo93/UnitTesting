using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Ja")]
        [Priority(1)]

        public void TestDivPos()
        {
            int expected = 5;
            int n = 20;
            int d = 4;
            int actual = Libarary.Calculator.Divide(n, d);
            System.Threading.Thread.Sleep(400);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Ty")]
        [Priority(1)]
        public void TestDivNeg()
        {
            int expected = -5;
            int n = -20;
            int d = 4;
            int actual = Libarary.Calculator.Divide(n, d);
            System.Threading.Thread.Sleep(100);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Ja")]
        [Priority(2)]
        public void CleanTest()
        {
            Assert.Inconclusive("Czysty test");
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDiv0()
        {
            int n = -20;
            int d = 0;
            try
            {
                Libarary.Calculator.Divide(n, d);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Dzielisz przez 0!", ex.Message);
                throw;
            }
        }
        [TestMethod]
        public void IsPos_True()
        {
            PrivateType p = new PrivateType(typeof(Libarary.Calculator));
            bool actual = (bool)p.InvokeStatic("IsPos", 1);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPos_TrueNonStatic()
        {
            PrivateObject p = new PrivateObject(typeof(Libarary.Calculator));
            bool actual = (bool)p.Invoke("IsPosNonStatic", -1);
            Assert.IsFalse(actual);
        }
    }
}
