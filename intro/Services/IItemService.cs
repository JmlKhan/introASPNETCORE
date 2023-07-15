using Microsoft.AspNetCore.Mvc;

namespace intro.Services
{
    public interface IItemService
    {
        public void CreateItem(Item item);
        public List<Item> GetAllItems();
        public Item GetItem(int id);

        public void DeleteItem(int id);

        public void UpdateItem(int id, Item item);
    }
}
