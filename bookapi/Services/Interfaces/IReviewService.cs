using Domain.Entities.Review;

namespace bookapi.Services.Interfaces
{
    public interface IReviewService
    {
        public List<ReviewEntity> GetReviewByBookId(string bookId);
    }
}
