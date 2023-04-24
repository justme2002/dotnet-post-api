using Domain.Entities.Book;

namespace bookapi.Services.Interfaces
{
    public interface IBookService
    {
        public List<BookEntity> getBookByAuthorId(string authorId);
    }
}
