using AutoMapper;
using bookapi.Services.Interfaces;
using Domain.DTO;
using Domain.Entities.Author;
using Domain.Entities.Book;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;

namespace bookapi.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;
        private readonly IBookService bookService;
        private readonly IMapper mapper;
        public AuthorService(IAuthorRepository authorRepository, IBookService bookService, IMapper mapper)
        {
            this.authorRepository = authorRepository;
            this.bookService = bookService;
            this.mapper = mapper;
        }

        public AuthorEntity getAuthorById(string id)
        {
            var result = this.authorRepository.GetQuery(author => author.Id == id);
            var books = this.bookService.getBookByAuthorId(result.Id!);
            return new AuthorEntity { 
                Id = result.Id,
                Name = result.Name,
                Follower = result.Follower,
                Books = books.ToList()
            };
        }

        public List<AuthorViewModel> getAuthors()
        {
            var authors = new List<AuthorViewModel>();
            foreach (var author in this.authorRepository.getAll())
            {
                var books = this.bookService.getBookByAuthorId(author.Id!);
                var booksViewModel = mapBookViewModel(books);
                var newAuthor = new AuthorViewModel
                {
                    Id = author.Id,
                    Name = author.Name,
                    Follower = author.Follower,
                    Books = booksViewModel
                };
                authors.Add(newAuthor);
            }
            return authors;
        }

        private List<BookViewModel> mapBookViewModel(List<BookEntity> books)
        {
            var booksViewModel = new List<BookViewModel>();
            foreach (var book in books)
            {
                var bookMapper = this.mapper.Map<BookEntity, BookViewModel>(book);
                booksViewModel.Add(bookMapper);
            }
            return booksViewModel;
        }
    }
}
