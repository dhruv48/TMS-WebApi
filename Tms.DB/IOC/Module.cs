using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.DB.Implement;
using Tms.DB.Interface;

namespace Tms.DB.IOC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>
            {
                {typeof(IMessageDB),typeof(MessageDB) }
            };
            return dic;
        }

    }
}
