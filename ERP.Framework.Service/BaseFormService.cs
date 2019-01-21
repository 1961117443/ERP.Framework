using ERP.Framework.IRepository;
using ERP.Framework.IService;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Service
{
    public class BaseFormService : IBaseFormService
    {
        #region 需要的服务，通过ioc注入
        protected readonly ISysToolBarRepository toolBarRepository;
        protected readonly ISysLayoutRepository layoutRepository; 
        #endregion

        public BaseFormService(
            ISysToolBarRepository sysToolBarRepository,
            ISysLayoutRepository sysLayoutRepository)
        {
            toolBarRepository = sysToolBarRepository;
            layoutRepository = sysLayoutRepository;
        }
        public List<VM_Toolbar> GetToolbars(SysModule sysModule)
        {
            return toolBarRepository.GetToolbars(sysModule);
            //return new List<VM_Toolbar>()
            //{
            //    new VM_Toolbar()
            //    {
            //        id=Guid.NewGuid().ToString(),
            //         title = "test1"
            //    }
            //};
        }
    }
}
