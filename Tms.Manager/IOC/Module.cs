using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.Manager.Implement;
using Tms.Manager.Interface;

namespace Tms.Manager.IOC
{
    public static class Module
    {
        public static  Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>
            {
                { typeof(IMessageManager) , typeof(MessageManager)}
            };
            return dic;
        }
    }
}
