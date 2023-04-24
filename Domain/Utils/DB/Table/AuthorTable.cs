using Domain.Entities.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils.DB.Table
{
    public class AuthorTable
    {
        public List<AuthorEntity> Authors { get; set; }
        public AuthorTable()
        {
            this.Authors = new List<AuthorEntity>
            {
                new AuthorEntity
                {
                    Id = "user1",
                    Name = "user 01",
                    Follower = 1234
                },
                new AuthorEntity
                {
                    Id = "user2",
                    Name = "user 02",
                    Follower = 432
                }
            };
        }
    }
}
