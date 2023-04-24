using Domain.Entities.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Author
{
    public class AuthorEntity
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Follower { get; set; }
        public virtual List<BookEntity>? Books { get; set; }
    }
}
