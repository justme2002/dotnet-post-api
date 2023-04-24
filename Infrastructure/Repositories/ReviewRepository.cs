using Domain.Entities.Review;
using Domain.Utils.DB.Table;
using Infrastructure.Base;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<ReviewEntity>, IReviewRepository
    {
        public ReviewRepository()
        {
            this.sets = new ReviewTable().Reviews;
        }
    }
}
