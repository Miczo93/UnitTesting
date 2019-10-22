using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Calculator.Test
{
    [TestClass]
    public class InitCleanTest3
    {
        
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext testContext)//zawsze na starcie
        {
            //MessageBox.Show("AssemblyInitialize");
        }
        [ClassInitialize()]
        public static void ClassInit(TestContext testContext)
        {
            MessageBox.Show("ClassInitialize");
        }
        [TestInitialize()]
        public void TestInit()
        {
            MessageBox.Show("TestInitialize");
        }
        [TestCleanup()]
        public void TestClean()
        {
            MessageBox.Show("TestCleanup");
        }
        [ClassCleanup()]
        public static void ClassClean()
        {
            MessageBox.Show("ClassCleanup");
        }
        [AssemblyCleanup()]
        public static void AssemblyClean()//zawsze na koncu
        {
            //MessageBox.Show("AssemblyCleanup");
        }
        
        [TestMethod()]
        public void TestMethod1()
        {
            MessageBox.Show("TestMethod1");
        }
        [TestMethod()]
        public void TestMethod2()
        {
            MessageBox.Show("TestMethod2");
        }

    }
}
