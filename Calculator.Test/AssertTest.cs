using System;
using System.Linq;
using System.Collections.Generic;
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
            Assert.AreEqual(excpected, actual, "{0} Power {1} is {2}", 5, 2, 25);
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
            Customer C1 = new Customer() { FirstName = "Ben", LastName = "Chord" };
            Customer C2 = new Customer() { FirstName = "Ben", LastName = "Chord" };
            // Assert.AreEqual(C1.FirstName, C2.FirstName);
            // Assert.AreEqual(C1.LastName, C2.LastName);
            Assert.IsTrue(AreCustomersEqual(C1, C2));//metoda

            // Assert.AreEqual(C1, C2);//nadpisana equals
        }

        private static bool AreCustomersEqual(Customer expected, Customer actual)
        {
            return expected.FirstName == actual.FirstName && expected.LastName == actual.LastName;
        }
    }

        [TestClass]
        public class CollectionAssertTest
        {

            [TestMethod]
            public void StringCollection()
            {
                List<string> col1 = new List<string>();
                col1.Add("A");
                col1.Add("B");
                col1.Add("C");
                List<string> col2 = new List<string>();
                col2.Add("A");
                col2.Add("B");
                col2.Add("C");
                CollectionAssert.AreEqual(col1, col2);
            }

        [TestMethod]
        public void ComplexObject()
        {
            List<Customer> col1 = new List<Customer>();
            col1.Add(new Customer() {FirstName ="Steve", LastName = "Johnson" });
            col1.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col1.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            List<Customer> col2 = new List<Customer>();
            col2.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col2.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col2.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            CollectionAssert.AreEqual(col1, col2); //nadpisana
        }
        [TestMethod]
        public void ComplexObjectCustomComparer()
        {
            List<Customer> col1 = new List<Customer>();
            col1.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col1.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col1.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            List<Customer> col2 = new List<Customer>();
            col2.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col2.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col2.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            CollectionAssert.AreEqual(col1, col2, new CustomerComparer()); 
        }

        [TestMethod]
        public void ComplexObjectToList()
        {
            List<Customer> col1 = new List<Customer>();
            col1.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col1.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col1.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            List<Customer> col2 = new List<Customer>();
            col2.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col2.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col2.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            CollectionAssert.AreEqual(col1.Select(x=>x.FirstName).ToList(), col2.Select(x => x.FirstName).ToList());
        }

        [TestMethod]
        public void ComplexObjectAreEquivalent()
        {
            List<Customer> col1 = new List<Customer>();
            col1.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col1.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col1.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            List<Customer> col2 = new List<Customer>();
            col2.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col2.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            col2.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            CollectionAssert.AreEquivalent(col1, col2);
        }
        [TestMethod]
        public void ComplexObjectContains()
        {
            List<Customer> col = new List<Customer>();
            col.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
          
            CollectionAssert.Contains(col, new Customer() { FirstName = "Steve", LastName = "Johnson" });
        }

        [TestMethod]
        public void ComplexObjectIsSubsetOf()
        {
            List<Customer> superset = new List<Customer>();
            superset.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            superset.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            superset.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            List<Customer> subset = new List<Customer>();
            subset.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            subset.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            CollectionAssert.IsSubsetOf(subset, superset);
        }

        [TestMethod]
        public void ComplexObjectAllItemsAreUnique()
        {
            List<Customer> col = new List<Customer>();
            col.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });

            CollectionAssert.AllItemsAreUnique(col);
        }

        [TestMethod]
        public void ComplexObjectAllINotNull()
        {
            List<Customer> col = new List<Customer>();
            col.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            col.Add(null);

            CollectionAssert.AllItemsAreNotNull(col);
        }

        [TestMethod]
        public void ComplexObjectInstance()
        {
            List<Customer> col = new List<Customer>();
            col.Add(new Customer() { FirstName = "Steve", LastName = "Johnson" });
            col.Add(new Customer() { FirstName = "Larry", LastName = "Brick" });
            col.Add(new Customer() { FirstName = "Bob", LastName = "Mon" });
            col.Add(new SuperCustomer());

            CollectionAssert.AllItemsAreInstancesOfType(col, typeof(Customer));
        }
    }

}
