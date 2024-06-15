using budgetmanagementsystem.application.Contracts.Users.UserClaims;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.UserClaim
{
    public static  class AddClaimExtension
    {
        public static IServiceCollection AddClaim(this IServiceCollection services)
        {

            services.AddScoped<IAddUserClaim, AddUserClaim>();
            return services;
        }
    }
}
