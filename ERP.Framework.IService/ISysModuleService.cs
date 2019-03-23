using ERP.Framework.Entity;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.IService
{

    public interface ISysModuleService
    {
        /// <summary>
        /// 获取工具栏列表
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        IList<SysToolBarDto> GetToolBars(string moduleId);
        /// <summary>
        /// 获取页面布局列表
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        IList<SysCustomLayoutDto> GetCustomLayouts(string moduleId);
    }
}
