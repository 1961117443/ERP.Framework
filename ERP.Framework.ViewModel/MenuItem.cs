using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.ViewModel
{
    public class ERPMenuItem
    {
        public string Id { get; set; }
        public string Caption { get; set; } 
        public  ICollection<ERPMenuItem> Child { get; set; }

    }
}
