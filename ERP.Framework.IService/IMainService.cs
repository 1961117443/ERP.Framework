using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.IService
{
    public interface IMainService
    {
        IList<ERPMenuItem> GetMenus();
    }
}
