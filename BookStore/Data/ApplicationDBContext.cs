using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Data

{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
