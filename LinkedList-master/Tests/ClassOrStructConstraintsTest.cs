using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ClassOrStructConstraintsTest
    {
        public static bool OpEqualsClassTest<T>(T s, T t) where T : class
        {
            return s == t;
        }

        //        public static void OpEqualsStructTest<T>(T s, T t) where T : struct 
        //        {
        //            System.Console.WriteLine(s == t);
        //        }

        public static string OpEqualsStructTest<T>(T s, T t) where T : struct
        {
            return s + t.ToString();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var i = 1;
            var j = 2;

            var s1 = "Hello";
            var s2 = "World";

            Assert.IsFalse(OpEqualsClassTest(s1, s2));

            Assert.AreEqual("12", OpEqualsStructTest(i, j));

            //OpEqualsStructTest(s1, s2);
            //OpEqualsClassTest(i,j);
        }
    }
}