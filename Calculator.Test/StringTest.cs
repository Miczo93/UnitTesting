using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void StartsWith()
        {
            StringAssert.StartsWith("Unit Test Practise", "Unit");
        }
        [TestMethod]
        public void EndsWith()
        {
            StringAssert.EndsWith("Unit Test Practise", "Practise");
        }
        [TestMethod]
        public void Contains()
        {
            StringAssert.Contains("Unit Test Practise", "Test");
        }
        [TestMethod]
        public void Match()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            StringAssert.Matches("aaaa@bbbb.com", regex);
        }

    }
}
