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
    public class Rotate13Tests
    {
        [TestMethod()]
        public void Rotate13FxTest1()
        {
            Assert.AreEqual("grfg", Rotate13.Rotate13Fx("test"));
            Assert.AreEqual("Grfg", Rotate13.Rotate13Fx("Test"));
        }

        [TestMethod()]
        public void Rotate13FxTest2()
        {
            Assert.AreEqual("10 + 2 vf gjryir.", Rotate13.Rotate13Fx("10 + 2 is twelve."));
        }

        [TestMethod()]
        public void Rotate13FxTest3()
        {
            Assert.AreEqual("Pbqrjnef", Rotate13.Rotate13Fx("Codewars"));
        }
        [TestMethod()]
        public void Rotate13FxTest4()
        {
            Assert.AreEqual("P# vf pbby!", Rotate13.Rotate13Fx("C# is cool!"));
        }
    }
}