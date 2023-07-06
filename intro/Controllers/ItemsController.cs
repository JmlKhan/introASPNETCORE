using intro.Data;
using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Item> CreateItem([FromBody] Item item)
        {
            var response =  _context.Items.Add(item);
            _context.SaveChanges();
            
            return NoContent();
        }



        [HttpGet]
        public ActionResult<List<Item>> GetItems()
        {
            var response = _context.Items.ToList();
            return Ok(response);
        }

        [HttpDelete("id")]
        public ActionResult DeleteItem([FromQuery]int id)
        {
            var itemToDelete = _context.Items.FirstOrDefault(x => x.Id == id); 
            _context.Items.Remove(itemToDelete);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
