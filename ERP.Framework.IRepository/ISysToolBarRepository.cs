using ERP.Framework.Entity;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.IRepository
{
    public interface ISysToolBarRepository:IBaseRepository<SysToolBar>
    {
        List<VM_Toolbar> GetToolbars(SysModule sysModule);

        List<SysToolBar> GetToolBars(SysModule sysModule);
    }
}
