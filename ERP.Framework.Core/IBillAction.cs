using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Core
{
    public interface IBillAction
    {
        string Name { get; }
        int BillStates { get;  }

        void Execute(BillContext contexts);

    }
}
