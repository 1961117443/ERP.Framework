using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Core.ButtonAction
{
    /// <summary>
    /// 新增操作
    /// </summary>
    public class NewAction : BaseAction
    {
        public override string Name
        {
            get
            {
                return "新增";
            }
        }

        public override int BillStates
        {
            get
            {
                return 1;
            }
        }

        public override void Execute(BillContext contexts)
        {

        }
    }
}
