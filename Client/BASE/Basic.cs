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
    public partial class Basic : Form
    {
        public Basic()
        {
            InitializeComponent();
        }

        #region 抽象行为
        /// <summary>
        /// 加载工具栏
        /// </summary>
        protected virtual void LoadToolBar()
        {

        }

        /// <summary>
        /// 加载界面布局
        /// </summary>
        protected virtual void LoadLayout()
        {

        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        protected virtual void BindData()
        {

        }
        #endregion

        protected override void OnShown(EventArgs e)
        { 
            base.OnShown(e);
            LoadToolBar();
            LoadLayout();
            BindData();
        }
    }
}
