using Microsoft.EntityFrameworkCore;

namespace BookApi.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set;}

        internal Task<Book> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
