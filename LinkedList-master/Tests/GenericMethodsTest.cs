using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    [TestClass]
    public class GenericMethodsTest
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        [TestMethod]
        public void SwapTest()
        {
            int a = 5;
            int b = 10;
            Swap(ref a, ref b);

            Assert.AreEqual(10, a);
            Assert.AreEqual(5, b);

            Swap<int>(ref a, ref b);

            Assert.AreEqual(5, a);
            Assert.AreEqual(10, b);

        }
    }
}
