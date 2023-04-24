using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IBaseRepository<T>
    {
        public T GetQuery(Predicate<T> expression);
        public IEnumerable<T> Where(Func<T, bool> expression);

    }
}
