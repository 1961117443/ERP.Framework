using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.BASE
{
    public abstract partial  class Base : Form
    {
        #region 抽象行为
        /// <summary>
        /// 加载工具栏
        /// </summary>
        public abstract void LoadToolBar();

        /// <summary>
        /// 加载界面布局
        /// </summary>
        public abstract void LoadLayout();

        /// <summary>
        /// 绑定数据
        /// </summary>
        public abstract void BindData();
        #endregion

        protected override void OnShown(EventArgs e)
        {
            MaximizeBox = false;
            MaximizeBox = false;
            WindowState = FormWindowState.Maximized;
            base.OnShown(e);
            LoadToolBar();
            LoadLayout();
            BindData();
        }
    }
}
