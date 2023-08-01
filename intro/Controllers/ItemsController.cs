using intro.Data;
using intro.DTOs;
using intro.Models;
using intro.Services;
using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;
        private static AppDbContext _context;


        public ItemsController(IItemService itemService, AppDbContext context)
        {
            _context = context;
            _itemService = itemService;
        }


        [HttpPost]
        public ActionResult<Item> CreateItem([FromBody] ItemRequestDTO item)
        {
            var newItem = new Item()
            {
                ItemGuid = Guid.NewGuid(),
                Name = item.Name,
                Description = item.Description,
                SensitiveData = item.SensitiveData,
            };

            _itemService.CreateItem(newItem);
            return Ok(item);
        }



        [HttpGet]
        public ActionResult<List<ItemsResponseDTO>> GetItems()
        {
            var items = _itemService.GetAllItems();
            var response = items.Select(i => new ItemsResponseDTO(i)).ToList();
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
