namespace intro.DTOs
{
    public class ItemsResponseDTO
    {
        public int Id { get; set; }

        public Guid ItemGuid { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ItemsResponseDTO(Item item)
        {
            Id = item.Id;
            ItemGuid = item.ItemGuid;
            Name = item.Name;
            Description = item.Description;
        }

    }
}
