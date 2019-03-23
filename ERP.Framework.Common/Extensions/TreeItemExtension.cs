using ERP.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Framework.Common.Extensions
{
    public static class TreeItemExtension
    {
        /// <summary>
        /// 向内层递归
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="action"></param>
        public static void RecursionEachIn<T>(this IEnumerable<T> data,Action<T> action)  where T: TreeItem<T>
        {
            foreach (var item in data)
            {
                //if (item.Children!=null && item.Children.Count()>0)
                //{
                //    foreach (var dto in item.Children)
                //    {
                //        ForEach(dto, action);
                //    }

                //}
                action(item);
                if (item.Children != null && item.Children.Count() > 0)
                {
                    //List<T> list = new List<T>();
                    //foreach (var dto in item.Children)
                    //{ 
                    //    list.Add((T)dto);
                    //} 
                    RecursionEachIn(item.Children.Cast<T>(), action);

                }
            }
        }

        /// <summary>
        /// 向外层递归
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="action"></param>
        public static void RecursionEachOut<T>(this IEnumerable<T> data, Action<T> action) where T : TreeItem<T>
        {
            foreach (var item in data)
            { 
                
                if (item.Children != null && item.Children.Count() > 0)
                { 
                    RecursionEachIn(item.Children.Cast<T>(), action); 
                }
                action(item);
            }
        }
    }
}
