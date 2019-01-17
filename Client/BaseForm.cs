using Client.Interfaces;
using ERP.Framework.Common.Attributes;
using ERP.Framework.IService;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class BaseForm : BASE.Base
    {
        [DependencyInjection]
        protected IBaseFormService FormService { get; set; }

        protected readonly SysModule SysModule;
        public BaseForm(SysModule sysModule)
        {
            SysModule = sysModule;
        }

        public override void BindData()
        {
        }

        public override void LoadLayout()
        {
        }

        public override void LoadToolBar()
        {
            var list = FormService.GetToolbars(SysModule);
            MessageBox.Show($"{list.Count}个按钮");
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e); 
            Text = SysModule.name;
            Name = SysModule.id;
        }
       
    }
}
