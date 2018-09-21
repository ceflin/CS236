using System;
using ExampleClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleClassLibTest
{
    [TestClass]
    public class IntSubtractionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sub = new IntSubtraction();
            Assert.AreEqual(0, sub.Operate(1, 1));
        }
    }
}
