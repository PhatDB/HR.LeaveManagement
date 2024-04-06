using HR.LeaveManagement.Service.CommandApplication.Contracts.Infrastructure;
using HR.LeaveManagement.Service.CommandApplication.Contracts.Presistence;
using HR.LeaveManagement.Service.CommandApplication.Models;
using HR.LeaveManagement.Service.CommandInfrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Service.CommandInfrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();

            return services;
        }
    }
}
