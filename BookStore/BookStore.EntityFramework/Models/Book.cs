using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data.EntityFramework.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublishYear { get; set; }
    }
}
