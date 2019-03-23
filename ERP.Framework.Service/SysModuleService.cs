using ERP.Framework.Core;
using ERP.Framework.IService;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Service
{
    public class SysModuleService : ISysModuleService
    {
        public IList<SysCustomLayoutDto> GetCustomLayouts(string moduleId)
        {
            return new List<SysCustomLayoutDto>();
        }

        public IList<SysToolBarDto> GetToolBars(string moduleId)
        {
            var tree = new List<SysToolBarDto>{
              new SysToolBarDto()
                {
                    ID = "1",
                    Title = "测试1",
                    Children = new List<SysToolBarDto>()
                     {
                         new SysToolBarDto()
                         {
                              ID="1-1",
                              Title = "测试1-1"
                         },
                         new SysToolBarDto()
                         {
                              ID="1-2",
                              Title = "测试1-2"
                         }
                    }
                },
              new SysToolBarDto()
                {
                    ID = "2",
                    Title = "测试2",
                    Children = new List<SysToolBarDto>()
                     {
                         new SysToolBarDto()
                         {
                              ID="2-1",
                              Title = "测试2-1"
                         },
                         new SysToolBarDto()
                         {
                              ID="2-2",
                              Title = "测试2-2"
                         }
                    }
                },
              new SysToolBarDto()
                {
                    ID = "2",
                    Title = "测试2"
                }
            };
            return tree;
        }
    }
}
