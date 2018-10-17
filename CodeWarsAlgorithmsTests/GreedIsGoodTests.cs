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
    public class GreedIsGoodTests
    {
        [TestMethod()]
        public void CalculateScoreTest1()
        {
            Assert.AreEqual(0, GreedIsGood.CalculateScore(new int[] { 2, 3, 4, 6, 2 }));
        }

        [TestMethod()]
        public void CalculateScoreTest2()
        {
            Assert.AreEqual(400, GreedIsGood.CalculateScore(new int[] { 4, 4, 4, 3, 3 }));
        }

        [TestMethod()]
        public void CalculateScoreTest3()
        {
            Assert.AreEqual(450, GreedIsGood.CalculateScore(new int[] { 2, 4, 4, 5, 4 }));
        }
    }
}