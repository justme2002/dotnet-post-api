using Domain.Entities.Author;
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
    public class AuthorRepository : BaseRepository<AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository()
        {
            this.sets = new AuthorTable().Authors;
        }

        public List<AuthorEntity> getAll()
        {
            return this.sets!;
        }
    }
}
