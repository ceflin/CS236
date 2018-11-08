namespace Lab07
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, int gradePoint, Status status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            GradePoint = gradePoint;
            Status = status;
        }

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int GradePoint { get; }
        public Status Status { get; }

        public override string ToString()
        {
            return
                $"Id:{Id}, FN:{FirstName}, LN:{LastName}, GP: {GradePoint}, S:{(Status == Status.FullTime ? "F" : "P")}";
        }
    }
}