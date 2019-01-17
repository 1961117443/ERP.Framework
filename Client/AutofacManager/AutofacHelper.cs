using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class AutofacHelper
    {
        protected static readonly IContainer _container;

        static AutofacHelper()
        {
            ContainerBuilder builder = new ContainerBuilder();

            #region 服务层
            var path = Path.Combine(Application.StartupPath, "ERP.Framework.Service.dll");
            Assembly assembly = Assembly.LoadFrom(path);
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces(); 
            #endregion

            #region 仓储层
            path = Path.Combine(Application.StartupPath, "ERP.Framework.Repository.SqlServer.dll");
            assembly = Assembly.LoadFrom(path);
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces(); 
            #endregion

            _container = builder.Build();
        }

        public static IContainer GetContainer()
        {
            return _container;
        }
    }
}
