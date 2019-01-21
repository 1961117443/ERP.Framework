using ERP.Framework.Common.Attributes;
using ERP.Framework.IService;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class BaseForm :  BASE.Base
    {
        [DependencyInjection]
        protected IBaseFormService FormService { get; set; }

        protected readonly SysModule SysModule;
        public BaseForm(SysModule sysModule):this()
        { 
            SysModule = sysModule;
        }
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void LoadToolBar()
        {
            var list = FormService.GetToolbars(SysModule);
            // toolStripBar.Items.Clear();
            foreach (var item in list)
            {
                ToolStripItem toolStripItem = toolStripBar.Items.Add(item.title);
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Text = SysModule.name;
            Name = SysModule.id;
        }
    }
}
