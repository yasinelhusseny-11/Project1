using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_1.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    
    {
        private readonly Librarycontext context;
        public BookController(Librarycontext _context)
        {
            context = _context;
        }
        //CRUD
        [HttpGet]
        
        public IActionResult GetBook()
        {
            List<Books> books =context.Book.ToList();
            return Ok(books);
        }
        [HttpGet("dto/{id:int}", Name = "BookDetailRoute")]
        public IActionResult GetById([FromRoute] int id)
        {
            Books book = context.Book.FirstOrDefault(b => b.BooksId == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("{Name:alpha}")]
        public IActionResult GetByName([FromRoute]String Name)
        {
            Books book =context.Book.FirstOrDefault(b=>b.BooksName == Name);
            if (book == null)
            {
                return NotFound(); 
            }
            return Ok(book);
        }
        [HttpPost]
        public IActionResult PostBook(Books newbook)
        {
            if (ModelState.IsValid)
            {
                context.Book.Add(newbook);
                context.SaveChanges();
                string url = Url.Link("BookDetailRoute", new { id = newbook.BooksId });
                return Created(url, newbook);
            }
            return BadRequest(ModelState);
        }
        [HttpPut("{Id}")]
        public IActionResult PutBook([FromRoute]int Id,[FromBody]Books book)
        {
            if (ModelState.IsValid)
            {
                Books oldbook = context.Book.FirstOrDefault(b => b.BooksId == Id);
                oldbook.BooksName = book.BooksName;
                oldbook.Author = book.Author;
                oldbook.Price = book.Price;
                oldbook.PublishedYear = book.PublishedYear;
                context.SaveChanges();
                return StatusCode(204);
            }
            return BadRequest();
        }
        [HttpDelete("{Id}")]
        public IActionResult RemoveBook(int Id)
        {
            try
            {
                Books book = context.Book.FirstOrDefault(b => b.BooksId == Id);
                context.Book.Remove(book);
                context.SaveChanges();
                return StatusCode(204);
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
