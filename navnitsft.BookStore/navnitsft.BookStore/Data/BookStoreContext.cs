using Microsoft.EntityFrameworkCore;

namespace navnitsft.BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) 
        { 
        
        }
        public DbSet<Books> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=LAPTOP-8P2PT8CB; Database=BookStore; User Id=sa; Password=123; Trusted_Connection=True; TrustServerCertificate=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
