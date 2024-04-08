using BaseLibraryData.Entities;
using GerenciadorLivros.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLivros.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BooksDbContext _booksContext;

        public BookController(BooksDbContext booksContext)
        {
            _booksContext = booksContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var book = _booksContext.Books.Where(b => b.IsDeleted is false).ToList();
            return Ok(book);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _booksContext.Books.SingleOrDefault(b => b.Id == id && b.IsDeleted is false);
            if(book is null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post(Book book)
        {
            _booksContext.Books.Add(book);
            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _booksContext.Books.SingleOrDefault(b => b.Id == id && b.IsDeleted is false);
            if (book is null)
            {
                return NotFound();
            }

            book.Delete();
            return NoContent();
        }
    }
}
