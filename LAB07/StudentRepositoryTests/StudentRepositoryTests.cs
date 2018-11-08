using System.Linq;
using Lab07;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentRepositoryTests
{
    [TestClass]
    public class StudentRepositoryTests
    {
        [TestMethod]
        public void AverageGradePointTest()
        {
            Assert.AreEqual(646.2, StudentRepository.AverageGradePoint());
        }

        [TestMethod]
        public void AverageGradePointStatusTest()
        {
            Assert.AreEqual(612.6, StudentRepository.AverageGradePoint(Status.FullTime));
        }

        [TestMethod]
        public void HighestGradePointTest()
        {
            Assert.AreEqual(867, StudentRepository.HighestGradePoint());
        }

        [TestMethod]
        public void LowestGradePointTest()
        {
            Assert.AreEqual(483, StudentRepository.LowestGradePoint());
        }

        [TestMethod]
        public void HighestStudentTest()
        {
            Assert.AreEqual(4, StudentRepository.HighestStudent().Id);
        }

        [TestMethod]
        public void HighestStudentStatusTest()
        {
            Assert.AreEqual(5, StudentRepository.HighestStudent(Status.FullTime).Id);
        }

        [TestMethod]
        public void LowestStudentTest()
        {
            Assert.AreEqual(3, StudentRepository.LowestStudent().Id);
        }

        [TestMethod]
        public void LowestStudentStatusTest()
        {
            Assert.AreEqual(3, StudentRepository.LowestStudent(Status.FullTime).Id);
        }

        [TestMethod]
        public void TopStudentsTest()
        {
            var actual = StudentRepository.TopNStudents(3).Select(s => s.Id).ToList();
            var expected = new[] {4, 10, 2};
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}