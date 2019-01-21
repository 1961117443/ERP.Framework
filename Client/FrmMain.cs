using Autofac;
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
using System.Reflection;
using ERP.Framework.Common.Attributes;
using System.Threading;

namespace Client
{
    //public class AsyncTest
    //{
    //    public static async Task Test1()
    //    {
    //        Task t=  test1();
    //        //test2();
    //      //  Console.WriteLine($"不知道test2有没有挂起 线程id:{Thread.CurrentThread.ManagedThreadId}"); 
    //       //await t;
    //        await Task.Run(() => { Thread.Sleep(2000); Console.WriteLine($"{DateTime.Now}异步方法执行完毕 线程id:{Thread.CurrentThread.ManagedThreadId}"); });
    //    }
    //    private static async Task test1()
    //    {
    //        Console.WriteLine($"{DateTime.Now}这是一个同步方法test1");
    //        await Task.Run(() => {Thread.Sleep(2000); Console.WriteLine($"{DateTime.Now}同步方法test1等1秒 线程id:{Thread.CurrentThread.ManagedThreadId}"); }); //异步等两秒
    //        Console.WriteLine($"{DateTime.Now}我都不知道这个方法什么时候执行！ 线程id:{Thread.CurrentThread.ManagedThreadId}");
            
    //    }
    //    private static void test2()
    //    {
    //        { Console.WriteLine($"{DateTime.Now}开始执行同步方法test2  线程id:{Thread.CurrentThread.ManagedThreadId}"); Thread.Sleep(4000); Console.WriteLine($"{DateTime.Now}同步方法test2  线程id:{Thread.CurrentThread.ManagedThreadId}"); }  

    //    }
    //}
    public partial class FrmMain : Form
    {
        protected readonly IMainService mainService;
        public FrmMain()
        {
            //AsyncTest.Test1();
            Console.WriteLine($"{DateTime.Now}初始化窗体");
            InitializeComponent();
            mainService = AutofacHelper.GetContainer().Resolve<IMainService>();
            InitToolMenu();
        }

        private void InitToolMenu()
        {
            var list = mainService.GetMenus();
            menuStrip.Items.Clear();

            Action<ERPMenuItem, ToolStripMenuItem> getMenu = null;
            getMenu = (data, p) =>
            {
                if (data.Child != null && data.Child.Count > 0)
                {
                    foreach (var item in data.Child)
                    {
                        var tMenu = new ToolStripMenuItem()
                        {
                            Name = item.Id,
                            Text = item.Caption
                        };
                        tMenu.Click += ShowModule;
                        getMenu(item, tMenu);
                        p.DropDownItems.Add(tMenu);
                    }
                }
            };
            foreach (var item in list)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem()
                {
                    Name = item.Id,
                    Text = item.Caption
                };
                getMenu(item, toolStripMenuItem);
                menuStrip.Items.Add(toolStripMenuItem);
            }

            ModuleList = new ToolStripMenuItem()
            {
                Name = Guid.Empty.ToString(),
                Text = "已经打开的模块"
            };
            menuStrip.Items.Add(ModuleList);
        }

        protected ToolStripMenuItem ModuleList { get; set; }

        private void ShowModule(object sender, EventArgs e)
        {
            var menu = sender as ToolStripMenuItem;
            if (menu != null && !menu.HasDropDownItems)
            {
                ShowModule(new SysModule() { id = menu.Name, name = menu.Text });
            }
        }

        private void ShowModule(SysModule sysModule)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == sysModule.id)
                {
                    // item.Show();
                    item.Activate();
                    //item.BringToFront();
                    //item.WindowState = FormWindowState.Maximized;
                    // this.ActivateMdiChild(item);
                    return;
                }
            }
            var form = new BaseForm(sysModule);
            form.MdiParent = this; 
            //form.MinimizeBox = false;
            //form.MaximizeBox = false;
            form.WindowState = FormWindowState.Maximized;

            #region 反射注入属性
            var props = form.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(w => w.GetCustomAttribute<DependencyInjectionAttribute>() != null);
            foreach (var p in props)
            {
                var obj = AutofacHelper.GetContainer().Resolve(p.PropertyType);
                if (obj != null)
                {
                    p.SetValue(form, obj);
                }
            }
            #endregion
            form.FormClosed += (o, e) =>
            {
                ModuleList.DropDownItems.RemoveByKey(form.Name);
            };
            form.Show();

            var index = ModuleList.DropDownItems.IndexOfKey(sysModule.id);
            if (index == -1)
            {
                var m = new ToolStripMenuItem() { Name = sysModule.id, Text = sysModule.name };
                m.Click += ShowModule;
                ModuleList.DropDownItems.Add(m);
            }
        }

    }
}
