using Domain.Entities.Book;
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
    public class BookRepository : BaseRepository<BookEntity>, IBookRepository
    {
        public BookRepository()
        {
            this.sets = new BookTable().Books;
        }
    }
}
