using intro.Services;
using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public ActionResult<Item> CreateItem([FromBody] Item item)
        {
            _itemService.CreateItem(item);
            return Ok(item);
        }



        [HttpGet]
        public ActionResult<List<Item>> GetItems()
        {
            var response = _itemService.GetAllItems();
            return Ok(response);
        }

        [HttpDelete("id")]
        public ActionResult DeleteItem([FromQuery] int id)
        {
            
            _itemService.DeleteItem(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, [FromBody] Item item)
        {
            _itemService.UpdateItem(id, item);
            return NoContent();
        }
    }
}
