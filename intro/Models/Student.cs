namespace intro.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
