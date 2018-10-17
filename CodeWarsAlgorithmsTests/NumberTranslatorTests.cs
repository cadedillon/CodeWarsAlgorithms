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
    public class NumberTranslatorTests
    {
        [TestMethod()]
        public void Number2WordsTest1()
        {
            Assert.AreEqual("zero", NumberTranslator.Number2Words(0));
            Assert.AreEqual("one", NumberTranslator.Number2Words(1));

        }

        [TestMethod()]
        public void Number2WordsTest2()
        {
            Assert.AreEqual("three", NumberTranslator.Number2Words(3));
            Assert.AreEqual("five", NumberTranslator.Number2Words(5));
            Assert.AreEqual("eight", NumberTranslator.Number2Words(8));
            Assert.AreEqual("three hundred one", NumberTranslator.Number2Words(301));

        }

        [TestMethod()]
        public void Number2WordsTest3()
        {
            Assert.AreEqual("seven hundred ninety-three", NumberTranslator.Number2Words(793));
            Assert.AreEqual("eight hundred", NumberTranslator.Number2Words(800));
            Assert.AreEqual("six hundred fifty", NumberTranslator.Number2Words(650));
            Assert.AreEqual("one thousand", NumberTranslator.Number2Words(1000));
            Assert.AreEqual("one thousand three", NumberTranslator.Number2Words(1003));
        }

        [TestMethod()]
        public void Number2WordsTest4()
        {
            Assert.AreEqual("ninety-nine thousand nine hundred ninety-nine", NumberTranslator.Number2Words(99999));
            Assert.AreEqual("eight hundred eighty-eight thousand eight hundred eighty-eight", NumberTranslator.Number2Words(888888));
            Assert.AreEqual("six million eight hundred forty-five thousand nine hundred twenty-one", NumberTranslator.Number2Words(6845921));
        }
    }
}