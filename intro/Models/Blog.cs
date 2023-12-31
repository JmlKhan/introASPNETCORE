﻿namespace intro.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public BlogHeader? Header { get; set; } // Reference navigation to dependent
    }

    public class BlogDTO
    {
        public int Id { get; set; }
    }
}
