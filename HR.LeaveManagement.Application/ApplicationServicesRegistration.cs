using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicatioServies(this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
