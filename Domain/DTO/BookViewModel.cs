using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class BookViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Stars { get; set; }
        public virtual List<ReviewViewModel>? Reviews { get; set; } = new List<ReviewViewModel>();

    }
}
