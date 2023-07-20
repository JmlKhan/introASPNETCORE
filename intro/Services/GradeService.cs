using intro.Data;
using intro.Models;

namespace intro.Services
{
    public class GradeService : IGradeService
    {
        private readonly AppDbContext _context;

        public GradeService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Grade> GetAll()
        {
          return  _context.Grades.ToList();
        }

        public void CreateGrade(Grade grade)
        {
            try
            {
                _context.Grades.Add(grade);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine("grade service:" + e);
            }
        }
    }
}
