using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class IngoreTimeTest
    {
        [TestMethod]
        [Timeout(1000)]//max time
        public void TestMethod1()
        {
            System.Threading.Thread.Sleep(2000);
        }

        [TestMethod]
        [Ignore]
        public void TestMethod2()
        {
        }
        [TestMethod]
        public void TestMethod3()
        {
        }

    }
}
