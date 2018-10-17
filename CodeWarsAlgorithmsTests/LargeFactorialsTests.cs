using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWarsAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsAlgorithms.Tests
{
    [TestClass()]
    public class LargeFactorialsTests
    {
        [TestMethod()]
        public void FactorialTest()
        {
            Assert.AreEqual("1", LargeFactorials.Factorial(1));
            Assert.AreEqual("120", LargeFactorials.Factorial(5));
            Assert.AreEqual("362880", LargeFactorials.Factorial(9));
            Assert.AreEqual("1307674368000", LargeFactorials.Factorial(15));
        }
    }
}