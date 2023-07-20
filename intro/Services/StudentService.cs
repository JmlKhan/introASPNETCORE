using intro.Data;
using intro.DTOs;
using intro.Models;
using Microsoft.EntityFrameworkCore;

namespace intro.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents(int gradeId)
        {
            try
            {
                return _context.Students.Where(x => x.GradeId == gradeId).Include(x => x.Grade);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void AddStudent(StudentDTO student)
        {
            try
            {
                var newStudent = new Student()
                {
                    StudentId = student.StudentId,
                    StudentName = student.StudentName,
                    GradeId = student.GradeId,
                };

                _context.Students.Add(newStudent);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
