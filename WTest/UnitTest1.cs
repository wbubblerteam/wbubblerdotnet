using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Wbubbler;

namespace WTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            wbu.bbler();
            Assert.AreEqual("hello, i am Wbubbler, your friend !\nbub is cool\nadd Wbubbler#7474 on discord.\ntell friends to install me i am funny", sw.ToString());
        }
    }
}