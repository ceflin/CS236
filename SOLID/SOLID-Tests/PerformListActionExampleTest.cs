using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;

namespace SOLID_Tests
{
    [TestClass]
    public class PerformListActionExampleTest
    {
        [TestMethod]
        public void DoActionTest()
        {
            var items = new List<int> {1, 2, 3};
            var ints = new int[] {1, 2, 3};

            PerformListActionExample.DoAction(items);

            PerformListActionExample.DoAction(items, Console.WriteLine);

            PerformListActionExample.DoAction(ints);

            PerformListActionExample.DoAction(ints, Console.WriteLine);
        }
    }
}