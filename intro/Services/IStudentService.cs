using intro.DTOs;
using intro.Models;

namespace intro.Services
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetStudents(int gradeId);

        public void AddStudent(StudentDTO student);
    }
}
