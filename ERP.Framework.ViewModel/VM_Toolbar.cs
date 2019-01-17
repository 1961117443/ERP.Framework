using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.ViewModel
{
    public class VM_Toolbar
    {
        public string id { get; set; }
        public string title { get; set; }

        public ICollection<VM_Toolbar> Child { get; set; }
    }
}
