using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.BaseRead
{
    public interface IBaseReadService<T, TSearch> where T : class where TSearch: class
    {
        public IEnumerable<T> Get(TSearch search = null);
        public T GetById(int id);
    }
}
