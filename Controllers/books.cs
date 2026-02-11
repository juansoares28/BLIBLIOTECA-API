using BLIBLIOTECA.Comunication.Resquest;
using BLIBLIOTECA.Models;
using BLIBLIOTECA.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace BLIBLIOTECA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books(IBookService bookService) : ControllerBase
    {
        private readonly IBookService _bookService = bookService;
        [HttpGet]
        public IActionResult GetallBooks()
        {
 
            var lista = _bookService.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById([FromRoute] int id)
        {
           
            var livro = _bookService.GetById(id);

            if (livro == null) return NotFound("Livro não encontrado");

            return Ok(livro);
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] Requestcreatbook request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            
            if (_bookService.Exists(request.Title, request.Author))
                return Conflict("Este livro já está cadastrado.");

            var newBook = new Livro(
                0,
                request.Title,
                request.Author,
                request.Year,
                request.Genre,
                request.Description,
                request.Price,
                request.Stock
            );

            _bookService.Add(newBook);

            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook([FromRoute] int id)
        {
           
            bool removido = _bookService.Delete(id);

            if (!removido)
            {
                return NotFound("Nenhum livro encontrado com esse ID.");
            }

            return NoContent(); 
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] Requestcreatbook request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);


            bool atualizado = _bookService.Update(id, request);

            if (!atualizado)
            {
                return NotFound("Livro não encontrado para atualização.");
            }

            return NoContent(); 
        }
    }
}

