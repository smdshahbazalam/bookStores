using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookStoreController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetBookList([FromServices] BookListQueryHandler handler)
        {
            return Ok(await handler.FetchAsync());
        }

        [HttpGet("search/{searchkey}")]
        public async Task<IActionResult> SearchBooks(string searchKey, [FromServices] SearchBookQueryHandler handler)
        {
            return Ok(await handler.FetchAsync(searchKey));
        }
    }
}
