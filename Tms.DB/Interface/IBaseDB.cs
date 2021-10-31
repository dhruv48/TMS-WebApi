using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tms.DB.Interface
{
    public interface IBaseDB<T>
    {
        List<T> GetAll();
        T GetBy(long Id);
        long Update(T obj ,long Id);
        long Add(T obj);

        void Delete(long Id);

    }
}
