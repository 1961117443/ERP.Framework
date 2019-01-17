using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    /// <summary>
    /// 窗体行为
    /// </summary>
    public interface IBaseForm
    { 
        /// <summary>
        /// 加载工具栏
        /// </summary>
        void LoadToolBar();

        /// <summary>
        /// 加载界面布局
        /// </summary>
        void LoadLayout();

        /// <summary>
        /// 绑定数据
        /// </summary>
        void BindData();
    }
}
