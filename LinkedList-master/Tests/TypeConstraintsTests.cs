using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TypeConstraintsTests
    {
        private static T Max<T>(T a, T b) where T : IComparable<T> // Self-referencing interface constraint
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        [TestMethod]
        public void MaxTest()
        {
            var maxInt = Max<int>(5, 10); // 10
            var maxAnimal = Max<string>("ant", "zebra"); // zoo

            Assert.AreEqual(10, maxInt);
            Assert.AreEqual("zebra", maxAnimal);
        }


        [TestMethod]
        public void MaxPersonTest()
        {
           var person1 = new Person {FirstName = "John", LastName = "Williams"};
           var person2 = new Person { FirstName = "Neo", LastName = "Anderson" };

           var maxPerson = Max<Person>(person1, person2);

           Assert.AreEqual(person1, maxPerson);
        }



        private class Person : IComparable<Person>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int CompareTo(Person otherPerson)
            {
                return string.Compare(LastName, otherPerson.LastName, StringComparison.CurrentCulture);
            }
        }
    }
}