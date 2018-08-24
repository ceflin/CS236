using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;

namespace SOLID_Tests
{
    [TestClass]
    public class SwapExampleTest
    {
        [TestMethod]
        public void SwapIntTest()
        {
            var a = 10;
            var b = 20;

            SwapExample.Swap(ref a, ref b);

            Assert.IsTrue(a == 20);
            Assert.IsTrue(b == 10);
        }
    }
}