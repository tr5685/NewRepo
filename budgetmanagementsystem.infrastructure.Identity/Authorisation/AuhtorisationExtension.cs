using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.Authorisation
{
    public static  class AuhtorisationExtension
    {
        public static IServiceCollection AddAuthorisationExtension(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("UserOnly", policy => policy.RequireClaim("UserId"));
                options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));

            });

            return services;
        }
    }
}
