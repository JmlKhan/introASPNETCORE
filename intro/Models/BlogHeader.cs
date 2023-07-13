namespace intro.Models;

public class BlogHeader
{
    public int Id { get; set; }
    public int BlogId { get; set; } // Required foreign key property
    public Blog? Blog { get; set; } = null!; // Required reference navigation to principal
}