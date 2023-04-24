using AutoMapper;
using bookapi.Services.Interfaces;
using Domain.DTO;
using Domain.Entities.Book;
using Domain.Entities.Review;
using Infrastructure.Interfaces;

namespace bookapi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly IReviewService reviewService;
        private readonly IMapper mapper;
        public BookService(IBookRepository bookRepository, IReviewService reviewService, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.reviewService = reviewService;
            this.mapper = mapper;
        }

        public List<BookEntity> getBookByAuthorId(string authorId)
        {
            var booksWithReview = new List<BookEntity>();
            var books = this.bookRepository!.Where(book => book.AuthorId == authorId);
            foreach (var book in books)
            {
                var reviews = this.reviewService!.GetReviewByBookId(book.Id!);
                book.Reviews!.AddRange(reviews);
                booksWithReview.Add(book);
            }
            return booksWithReview;
        }
    }
}
