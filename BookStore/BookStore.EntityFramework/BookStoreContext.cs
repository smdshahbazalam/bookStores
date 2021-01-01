using BookStore.Data.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.EntityFramework
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(
           DbContextOptions<BookStoreContext> options)
           : base(options)
        { }

        public virtual DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BookConfiguration());
        }

    }
}
