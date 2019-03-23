using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Core
{
    public abstract class BaseAction : IBillAction
    {
        public abstract string Name { get; }

        public abstract int BillStates { get; }

        public abstract void Execute(BillContext contexts);
    }
}
