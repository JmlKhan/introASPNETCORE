using intro.Data;
using Microsoft.EntityFrameworkCore;

namespace intro.Services
{
    public class ItemService : IItemService
    {
        private readonly AppDbContext _context;
        public ItemService(AppDbContext context)
        {
            _context = context;
        }

        public Item GetItem(int id)
        {
            var item = _context.Items.FirstOrDefault(x => x.Id == id);
            
            return item;
        }

        public void DeleteItem(int id)
        {
            var itemToDelete = _context.Items.FirstOrDefault(x => x.Id == id);
            _context.Items.Remove(itemToDelete);
            _context.SaveChanges();
        }

        public void UpdateItem(int id, Item item)
        {

            if (item.Id != id)
            {
                throw new Exception("id not found");
            }

            _context.Entry(item).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void CreateItem(Item item)
        {
            var response = _context.Items.Add(item);
            _context.SaveChanges();
        }

        public List<Item> GetAllItems()
        {
            try
            {
                var items = _context.Items.ToList();
                return items;
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
