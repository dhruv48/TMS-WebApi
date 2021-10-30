using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tms.Manager.Interface
{
    public interface IBaseManager<T>
    {
        List<T> GetAll();
        long Update(T obj);
        long Add(T obj);
        T GetBy(long Id);
    }
}
