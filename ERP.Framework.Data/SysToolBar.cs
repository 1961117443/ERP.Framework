using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Entity
{
    public class SysToolBar
    {
        public Guid ID { get; set; }
        public string SysModuleID { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 上级id
        /// </summary>
        public Guid ParentID { get; set; }
    }
}
