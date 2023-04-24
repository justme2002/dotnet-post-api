using Domain.Entities.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IAuthorRepository : IBaseRepository<AuthorEntity>
    {
        List<AuthorEntity> getAll();
    }
}

