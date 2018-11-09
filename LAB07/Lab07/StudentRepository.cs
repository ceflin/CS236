using System.Collections.Generic;
using System.Linq;

namespace Lab07
{
    public static class StudentRepository
    {
        private static readonly IEnumerable<Student> Students = GetStudentRecords();

        public static double AverageGradePoint()
        {
            return Students
                .Select(s => s.GradePoint).Average();
        }

        public static double HighestGradePoint()
        {
            return 0;
        }

        public static double LowestGradePoint()
        {
            return 0;
        }

        public static double AverageGradePoint(Status status)
        {
            //Hint: first filter by status
            return 0;
        }

        public static Student HighestStudent()
        {
            return Students
                .OrderByDescending(s => s.GradePoint)
                .FirstOrDefault();
        }

        public static Student HighestStudent(Status status)
        {
            return Students
        }

        public static Student LowestStudent()
        {
            return null;
        }

        public static Student LowestStudent(Status status)
        {
            return null;
        }

        public static IEnumerable<Student> TopNStudents(int n)
        {
            //hint: use the take function
            return null;
        }

        public static void PrintReport()
        {
            //Your select clause will map to an anonymous type that has an Id and Name property.
            //the Id must be the student Id
            //The Name must be the Student's in the format of last name, first name.
            // ex: "Villareal, Byron"
            //Uncomment the lines below and fix

//            var query = Students;
//                .OrderByDescending(s => s.LastName)
//                .Select(?????);


            // foreach (var q in query) Console.WriteLine($"{q.Id} {q.Name}");
        }

        public static IEnumerable<Student> StudentsByStatus(Status status)
        {
            return Students.Where(s => s.Status == status);
        }

        private static IEnumerable<Student> GetStudentRecords()
        {
            return new List<Student>
            {
                new Student(1, "Byron", "Villareal", 612, Status.FullTime),
                new Student(2, "Rodrick", "Aceves", 686, Status.PartTime),
                new Student(3, "Floyd", "Althoff", 483, Status.FullTime),
                new Student(4, "Danny", "Vanmeter", 867, Status.PartTime),
                new Student(5, "Lemuel", "Ebert", 680, Status.FullTime),
                new Student(6, "Annalee", "Hovis", 484, Status.PartTime),
                new Student(7, "Natasha", "Lamarr", 665, Status.FullTime),
                new Student(8, "Vella", "Reddick", 547, Status.PartTime),
                new Student(9, "Chia", "Marcum", 623, Status.FullTime),
                new Student(10, "Shu", "Van", 815, Status.PartTime)
            };
        }
    }
}