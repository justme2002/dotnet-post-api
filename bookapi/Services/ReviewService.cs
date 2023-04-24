using bookapi.Services.Interfaces;
using Domain.Entities.Review;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;

namespace bookapi.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }

        public List<ReviewEntity> GetReviewByBookId(string bookId)
        {
            return this.reviewRepository!.Where(review => review.BookId == bookId).ToList();
        }
    }
}
