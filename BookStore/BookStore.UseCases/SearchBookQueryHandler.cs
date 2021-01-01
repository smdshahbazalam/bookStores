using BookStore.Data.EntityFramework;
using BookStore.Data.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UseCases
{
    public class SearchBookQueryHandler
    {
        private readonly BookStoreContext bookStoredbContext;

        public SearchBookQueryHandler(BookStoreContext bookStoredbContext)
        {
            this.bookStoredbContext = bookStoredbContext;
        }

        public async Task<Book[]> FetchAsync(string searchKey)
        {
            return await bookStoredbContext.Books
                .Where(u => EF.Functions.Like(u.Name, $"{searchKey}%")
                || EF.Functions.Like(u.Author, $"{searchKey}%")).ToArrayAsync();
        }
    }
}
