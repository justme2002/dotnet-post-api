using Domain.Entities.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils.DB.Table
{
    public class BookTable
    {
        public List<BookEntity>? Books { get; set; }
        public BookTable()
        {
            this.Books = new List<BookEntity>
            {
                new BookEntity
                {
                    Id = "book1",
                    Name = "Book 1",
                    Stars = 4.5,
                    AuthorId = "user1",
                },
                new BookEntity
                {
                    Id = "book2",
                    Name = "Book 2",
                    Stars = 3.9,
                    AuthorId = "user1"
                },
                new BookEntity
                {
                    Id = "book3",
                    Name = "Book 3",
                    Stars = 4.0,
                    AuthorId = "user2"
                }
            };
        }
    }
}
