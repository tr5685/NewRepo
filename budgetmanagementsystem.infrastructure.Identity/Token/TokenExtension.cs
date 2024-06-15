using budgetmanagementsystem.application.Contracts.Users.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.Token
{
    public static  class TokenExtension
    {
        public static IServiceCollection AddTokenService(this IServiceCollection services)
        {
            services.AddScoped<IGenerateToken, GenerateToken>();
            return services;
        }



    }
}
