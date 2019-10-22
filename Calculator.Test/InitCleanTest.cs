using System;
using Calculator.Libarary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class InitCleanTest
    {
        Rectangle rec;

        [TestInitialize]//uzyje sie przed kazdym testem (musi być public)
        public void Setup()
        {
            rec = new Rectangle();
            rec.Width = 3;
            rec.Lenght = 4;
        }

        [TestCleanup]//uzyje sie po każdym tescie (musi być public)
        public void Cleanup()
        {
            rec = null;
        }

        [TestMethod]
        public void PeremeterTest()
        {
            double expected = 14;
            double actual = rec.Perimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            double expected = 12;
            double actual = rec.Area();
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class InitCleanTest2
    {
        private static Rectangle rec;

        [ClassInitialize]//uzyje sie 1 jako pierwsze w klasie, public static i testContext
        public static void Setup(TestContext testContext)
        {
            rec = new Rectangle();
            rec.Width = 3;
            rec.Lenght = 4;
        }

        [ClassCleanup]//uzyje się 1 po wszystkim jako ostatnie w klasie, public static
        public static void Cleanup()
        {
            rec = null;
        }

        [TestMethod]
        public void PeremeterTest()
        {
            double expected = 14;
            double actual = rec.Perimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            double expected = 12;
            double actual = rec.Area();
            Assert.AreEqual(expected, actual);
        }
    }


}
