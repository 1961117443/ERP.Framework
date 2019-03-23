using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.IRepository
{
    public interface IBaseRepository<T>
    {
        List<T> GetList();
        List<T> GetList(Expression<Func<T, bool>> where);
    }
}
