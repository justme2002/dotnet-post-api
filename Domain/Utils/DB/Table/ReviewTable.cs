using Domain.Entities.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils.DB.Table
{
    public class ReviewTable
    {
        public List<ReviewEntity> Reviews { get; set; }
        public ReviewTable()
        {
            this.Reviews = new List<ReviewEntity>
            {
                new ReviewEntity
                {
                    Reviewer = "Reviewer 1",
                    Content = "Good book",
                    BookId = "book1"
                },
                new ReviewEntity
                {
                    Reviewer = "Reviewer 2",
                    Content = "I love this book",
                    BookId = "book1"
                }
            };

        }
    }
}
