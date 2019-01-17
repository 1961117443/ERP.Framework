using ERP.Framework.IService;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Service
{
    public class MainService : IMainService
    {
        public IList<ERPMenuItem> GetMenus()
        {
            IList<ERPMenuItem> menuItems = new List<ERPMenuItem>();
            ERPMenuItem menu = new ERPMenuItem()
            {
                Id = "001",
                Caption = "系统设置"
            };
            menuItems.Add(menu);

            menu = new ERPMenuItem()
            {
                Id = "002",
                Caption = "测试菜单",
                Child = new List<ERPMenuItem>()
                {
                    new ERPMenuItem()
                    {
                        Id="00201",
                        Caption="模块1"
                    },
                    new ERPMenuItem()
                    {
                        Id="00202",
                        Caption="模块2"
                    },
                    new ERPMenuItem()
                    {
                        Id="00203",
                        Caption="模块3",
                Child = new List<ERPMenuItem>()
                {
                    new ERPMenuItem()
                    {
                        Id="0020301",
                        Caption="模块3-1"
                    },
                    new ERPMenuItem()
                    {
                        Id="0020302",
                        Caption="模块3-2"
                    },
                    new ERPMenuItem()
                    {
                        Id="0020303",
                        Caption="模块3-3"
                    }
                }
                    }
                }
            };
            menuItems.Add(menu);
            return menuItems;
        }
    }
}
