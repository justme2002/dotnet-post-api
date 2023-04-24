using Domain.Entities.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Review
{
    public class ReviewEntity
    {
        public string? Reviewer { get; set; }
        public string? Content { get; set; }
        public virtual string? BookId { get; set; }
    }
}
