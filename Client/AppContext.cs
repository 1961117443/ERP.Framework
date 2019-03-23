using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class AppContext
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public string SysModuleID { get; set; }
        /// <summary>
        /// 工具栏按钮
        /// </summary>
        public IEnumerable<SysToolBarDto> ToolBarList { get; set; }
        /// <summary>
        /// 布局控件
        /// </summary>
        public IEnumerable<SysCustomLayoutDto> LayoutList { get; set; }
        /// <summary>
        /// 绑定的数据源
        /// </summary>
        public IDictionary<string, DataTable> BindDataTable { get; set; }

        public AppContext()
        {
            ToolBarList = new List<SysToolBarDto>();
            LayoutList = new List<SysCustomLayoutDto>();
            BindDataTable = new Dictionary<string, DataTable>();
        }

    }
}
