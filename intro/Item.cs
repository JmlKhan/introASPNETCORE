using System.ComponentModel.DataAnnotations;

namespace intro
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public Guid ItemGuid { get; set; }

        public string Name  { get; set; }

        public string Description { get; set; }

        public string SensitiveData { get; set; }
    }
}
