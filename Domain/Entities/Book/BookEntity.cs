using Domain.Entities.Author;
using Domain.Entities.Review;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Book
{
    public class BookEntity
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Stars { get; set; }
        public virtual string? AuthorId { get; set; }
        public virtual List<ReviewEntity>? Reviews { get; set; } = new List<ReviewEntity>();
    }
}
