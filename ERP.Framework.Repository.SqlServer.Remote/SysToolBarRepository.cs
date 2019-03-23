using ERP.Framework.Entity;
using ERP.Framework.IRepository;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Repository.SqlServer.Remote
{
    public class SysToolBarRepository : ISysToolBarRepository
    {
        public List<SysToolBar> GetList()
        {
            throw new NotImplementedException();
        }

        public List<SysToolBar> GetList(Expression<Func<SysToolBar, bool>> where)
        {
            throw new NotImplementedException();
        }

        public List<VM_Toolbar> GetToolbars(SysModule sysModule)
        {
            var list = new List<VM_Toolbar>()
            {
                new VM_Toolbar()
                {
                    id=Guid.NewGuid().ToString(),
                     title = "test1:Remote"
                }
            };
            return list;
        }

        public List<SysToolBar> GetToolBars(SysModule sysModule)
        {
            throw new NotImplementedException();
        }
    }
}
