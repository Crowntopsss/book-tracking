using Microsoft.EntityFrameworkCore;
using BookTracking.Models;
public class BookTrackingDbContext : DbContext
{
    public BookTrackingDbContext(DbContextOptions<BookTrackingDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryType> CategoryTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define relationships and configurations here, if needed
    }
}