﻿namespace intro.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public virtual IList<Student> Students { get; set; }
    }
}
