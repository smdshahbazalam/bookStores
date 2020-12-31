using BookStore.Data.EntityFramework;
using BookStore.Data.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UseCases
{
    public class BookListQueryHandler
    {
        private readonly BookStoreContext bookStoredbContext;

        public BookListQueryHandler(BookStoreContext bookStoredbContext)
        {
            this.bookStoredbContext = bookStoredbContext;
        }

        public async Task<Book[]> FetchAsync()
        {
            return await bookStoredbContext.Books.ToArrayAsync();
        }
    }
}
