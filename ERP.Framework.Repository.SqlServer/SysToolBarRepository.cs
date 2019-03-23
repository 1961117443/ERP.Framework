using ERP.Framework.Entity;
using ERP.Framework.IRepository;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Repository.SqlServer
{
    public class SysToolBarRepository: BaseRepository<SysToolBar>,ISysToolBarRepository
    {
        public List<VM_Toolbar> GetToolbars(SysModule sysModule)
        {
            var list= new List<VM_Toolbar>()
            {
                new VM_Toolbar()
                {
                    id=Guid.NewGuid().ToString(),
                     title = "test1"
                }
            };
            return list;
        }

        public List<SysToolBar> GetToolBars(SysModule sysModule)
        {
            return new List<SysToolBar>();
        }
    }
}
