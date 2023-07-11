using System.Collections;

namespace intro.Services
{
    public class BetterItemService : IItemService
    {
        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItems()
        {
            Console.WriteLine("from better service");
            return (List<Item>)Enumerable.Empty<Item>();
        }

        public Item GetItem(int id)
        {
            Console.WriteLine("from better service");
            return null;
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(int id, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
