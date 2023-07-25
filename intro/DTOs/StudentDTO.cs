using intro.Models;
using System.ComponentModel.DataAnnotations;

namespace intro.DTOs
{
    public class StudentDTO
    {
        public int StudentId { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "tog'ri ism kiriting")]
        public string StudentName { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "iltimos to'g'ri kursni kiriting!")]
        public int GradeId { get; set; }
    }
}
