using System;
using Calculator.Libarary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CaculatorTest2
    {
        private TestContext _testContext;

        public TestContext TestContext
        {
            get
            {
                return _testContext;
            }
            set
            {
                _testContext = value;
            }
        }

        [TestCleanup]//zawsze po każdym unit tescie
        public void CleanUp()
        {
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());
        }

        [TestMethod][TestCategory("Other"), TestCategory("Calculator")][TestProperty("Test Group", "Performance")][Owner("Ty")][Priority(3)]
        public void TestMethod1()
        {
            TestContext.WriteLine(TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine(TestContext.TestName);
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());

        }

        [TestMethod][TestCategory("Other")][TestProperty("Test Group", "Security")][Owner("Ja")][Priority(3)]
        public void TestMethod2()
        {
           System.Diagnostics.Debug.WriteLine("Debug: TM2 excuted");
           TestContext.WriteLine("TestContext: TM2 excuted");
        }

        [TestMethod]
        [DataSource("System.Data.SqlClient"
            , "data source = DESKTOP-S15FSJL;database=Testing;integrated security=true",
            "EmployeeUT",
            DataAccessMethod.Sequential)]
        public void DataDrivenTestDatabase()
        {
            Employee emp = new Employee();
            emp.Name = TestContext.DataRow["Name"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();
            Assert.IsNotNull(emp.Name);
            Assert.IsNotNull(emp.Email);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Employees.xml",
            "Employee",
             DataAccessMethod.Sequential)] //always copy to output
        public void DataDrivenTestXML()
        {
            Employee emp = new Employee();
            emp.Name = TestContext.DataRow["Name"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();
            Assert.IsNotNull(emp.Name);
            Assert.IsNotNull(emp.Email);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    "Employee.csv",
    "Employee.csv",
     DataAccessMethod.Sequential)] //always copy to output
        public void DataDrivenTestCSV()
        {
            Employee emp = new Employee();
            emp.Name = TestContext.DataRow["Name"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();
            Assert.IsNotNull(emp.Name);
            Assert.IsNotNull(emp.Email);
        }

        [TestMethod]
        [DataSource("UnitTestDataSource")]//app.config sobie zmieniam
        public void DataDrivenTestAll()
        {
            Employee emp = new Employee();
            emp.Name = TestContext.DataRow["Name"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();
            Assert.IsNotNull(emp.Name);
            Assert.IsNotNull(emp.Email);
        }
    }
}
