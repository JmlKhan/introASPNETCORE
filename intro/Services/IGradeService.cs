using intro.Models;

namespace intro.Services
{
    public interface IGradeService
    {
        public IEnumerable<Grade> GetAll();

        public void CreateGrade(Grade grade);
    }
}
