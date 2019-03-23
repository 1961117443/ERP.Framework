using ERP.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.ViewModel
{
    public class SysToolBarDto:TreeItem<SysToolBarDto>
    {
        public string ID { get; set; }
        public string Title { get; set; }
    }
}
