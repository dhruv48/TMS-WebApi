using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS.Api.IOC
{
    public static class IOCConfiguration
    {
        public static void Configuration(IServiceCollection services)
        {
            Configure(services, Tms.Manager.IOC.Module.GetTypes());
            Configure(services, Tms.DB.IOC.Module.GetTypes());
        }

        private static void Configure(IServiceCollection services, Dictionary<Type, Type> types)
        {
            foreach (var type in types)
            {
                services.AddScoped(type.Key, type.Value);
            }
        }
    }
}
