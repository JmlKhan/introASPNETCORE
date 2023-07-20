using intro.Models;
using Microsoft.EntityFrameworkCore;

namespace intro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<BlogHeader> BlogsHeaders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasOne(e => e.Header)
                .WithOne(e => e.Blog)
                .HasForeignKey<BlogHeader>(e => e.BlogId)
                .IsRequired(false);
        }
    }
}
