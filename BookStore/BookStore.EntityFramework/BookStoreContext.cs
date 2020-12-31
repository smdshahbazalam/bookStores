using BookStore.Data.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

    }
}
