using Domain.DTO;
using Domain.Entities.Author;

namespace bookapi.Services.Interfaces
{
    public interface IAuthorService
    {
        public AuthorEntity getAuthorById(string id);
        public List<AuthorViewModel> getAuthors();
    }
}
