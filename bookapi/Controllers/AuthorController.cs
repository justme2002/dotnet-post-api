using bookapi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService authorService;
        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet("/author/{authorId}/books")]
        public IActionResult getAuthorById(string authorId)
        {
            var result = this.authorService.getAuthorById(authorId);
            return Ok(result);
        }
        [HttpGet("/authors")]
        public IActionResult getAuthors()
        {
            var result = this.authorService.getAuthors();
            return Ok(result);
        }
    }
}
