using ERP.Framework.Common.Attributes;
using ERP.Framework.Common.Extensions;
using ERP.Framework.Core;
using ERP.Framework.IService;
using ERP.Framework.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class BaseForm :  BASE.Basic
    {
        public static MethodInfo InitMethod = typeof(BaseForm).GetMethod(nameof(InitAppContext), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        [DependencyInjection]
        protected IBaseFormService FormService { get; set; }


        [DependencyInjection]
        protected ISysModuleService sysModuleService { get; set; }


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
            // toolStripBar.Items.Clear();
            var tree = Context.ToolBarList;
            tree.RecursionEachIn(w =>
            {
                ToolStripItem toolStripItem = toolStripBar.Items.Add(w.Title);
                if (w.Children!=null && w.Children.Count()>0)
                {
                   
                }
               

            });
            //foreach (SysToolBarDto dto in Context.ToolBarList)
            //{ 
            //    ToolStripItem toolStripItem = toolStripBar.Items.Add(dto.Title);
            //}
        } 
       
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Text = SysModule.name;
            Name = SysModule.id;
        }


        /// <summary>
        /// 数据上下文
        /// 包含模块的属性，事件，以及数据
        /// </summary>
        public AppContext Context { get; set; }

        /// <summary>
        /// 初始化数据上下文
        /// </summary>
        private void InitAppContext()
        {
            if (Context == null)
            {
                Context = new AppContext();
            }


            Context.SysModuleID = this.SysModule.id;


            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Run(() => Context.ToolBarList = sysModuleService.GetToolBars(Context.SysModuleID)));
           // tasks.Add(Task.Run(() => Context.LayoutList = sysModuleService.GetCustomLayouts(Context.SysModuleID)));
            Task.WaitAll(tasks.ToArray());
        }

    }
}
