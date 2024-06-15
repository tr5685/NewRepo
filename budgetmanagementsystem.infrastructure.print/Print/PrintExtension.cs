using budgetmanagementsystem.application.Contracts.Specifications.Client.Print;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.print.Print
{
    public static  class PrintExtension
    {
        public static IServiceCollection AddPrintService(this IServiceCollection services)
        {
            services.AddScoped<IPrint, Print>();
            return services;
        }
        
    }
}
