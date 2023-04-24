﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class AuthorViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Follower { get; set; }
        public virtual List<BookViewModel>? Books { get; set; }
    }
}
