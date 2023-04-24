using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base
{
    public class BaseRepository<T>: IBaseRepository<T>
    {
        public List<T>? sets { get; set; }
        public T GetQuery(Predicate<T> expression)
        {
            return this.sets!.Find(expression)!;
        }

        public IEnumerable<T> Where(Func<T, bool> expression)
        {
            return this.sets!.Where(expression);
        }
    }
}
