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
    public class MorseDecoderTests
    {
        [TestMethod()]
        public void DecodeTest1()
        {
            Assert.AreEqual("HEY JUDE", MorseDecoder.Decode(".... . -.--   .--- ..- -.. ."));
        }

        [TestMethod()]
        public void DecodeTest2()
        {
            Assert.AreEqual("HELLO WORLD", MorseDecoder.Decode(".... . .-.. .-.. ---   .-- --- .-. .-.. -.."));
        }
    }
}