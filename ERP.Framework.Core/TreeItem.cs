using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Core
{
    public class TreeItem<T>
    {
        //public string ID { get; set; }
        //public string ParentID { get; set; }
        //public string Title { get; set; }
        public T Item { get; set; }
        public IEnumerable<TreeItem<T>> Children { get; set; }
    }
}
