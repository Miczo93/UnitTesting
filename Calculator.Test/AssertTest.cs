using System;
using Calculator.Libarary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class AssertTest
    {
        [TestMethod]
        public void AreEqual()
        {
            double excpected = 25;
            double actual = Math.Pow(5, 2);
            Assert.AreEqual(excpected, actual, "{0} Power {1} is {2}",5,2,25);
            //Assert.AreNotEqual(excpected, actual, "{0} Power {1} is not {2}", 5, 2, 26);
        }
        [TestMethod]
        public void AreSame()
        {
            Employee E1 = new Employee();
            Employee E2 = new Employee();
            Assert.AreSame(E1, E2);
            //Assert.AreNotSame(E1, E2);
        }
        [TestMethod]
        public void Fail()
        {
            Assert.Fail("Fail without test");
        }
        [TestMethod]
        public void Inconclusive()//for not implemeting
        {
            Assert.Inconclusive("Cannot state");
        }
        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(true);
            //Assert.IsFlase(false);
        }
        [TestMethod]
        public void IsNull()
        {
            Assert.IsNull(new Employee());
           // Assert.IsNotNull(null);
        }

        [TestMethod]
        public void IsInstanceOfType()
        {
            Employee E1 = new Employee();
            Assert.IsInstanceOfType(E1, typeof(Employee));
        }

        [TestMethod]
        public void ObjectEquality()
        {
            Customers C1 = new Customers() {FirstName = "Ben", LastName="Chord" };
            Customers C2 = new Customers() { FirstName = "Ben", LastName ="Chord" };
           // Assert.AreEqual(C1.FirstName, C2.FirstName);
           // Assert.AreEqual(C1.LastName, C2.LastName);
            Assert.IsTrue(AreCustomersEqual(C1, C2));//metoda

           // Assert.AreEqual(C1, C2);//nadpisana equals
        }

        private static bool AreCustomersEqual(Customers expected, Customers actual)
        {
            return expected.FirstName == actual.FirstName && expected.LastName == actual.LastName; 
        }


    }
}
