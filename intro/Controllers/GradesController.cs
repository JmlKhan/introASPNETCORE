using intro.Models;
using intro.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IGradeService _service;

        public GradesController(IGradeService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult CreateGrade([FromBody] Grade grade)
        {
            try
            {
                _service.CreateGrade(grade);
                
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                
            }

        }

        [HttpGet]
        public ActionResult<IEnumerable<Grade>> GetGrades()
        {
            try
            {
                var grades = _service.GetAll();
                return Ok(grades);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
