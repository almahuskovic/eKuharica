using eKuharica.Services.BaseRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.BaseCRUD
{
    public interface IBaseCRUDService<T, TSearch, TInsert, TUpdate> : IBaseReadService<T, TSearch>
      where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);
        T Delete(int id);
    }
}
