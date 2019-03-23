using ERP.Framework.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Repository.SqlServer
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public List<T> GetList(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
