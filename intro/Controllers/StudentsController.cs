using intro.DTOs;
using intro.Models;
using intro.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult CreateStudent([FromBody] StudentDTO student)
        {
            try
            {
                _service.AddStudent(student);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("{gradeId:int}")]
        public ActionResult<IEnumerable<Student>> GetStudents(int gradeId)
        {
            try
            {
               var studetns =  _service.GetStudents(gradeId);
               return Ok(studetns);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }
    }
}
