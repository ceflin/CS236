using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class OverloadingGenericMethodTests
    {
        public static string GetData<T>(T obj)
        {
            return $"INSIDE GetData<T>,{obj.GetType().Name}";
        }

        public static string GetData<T, U>(T obj1, U obj2)
        {
            return $"INSIDE GetData<T, U>, {obj1.GetType().Name} {obj2.GetType().Name}";
        }

        public static string GetData(int x)
        {
            return $"INSIDE GetData{x.GetType().Name}";
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}