using budgetmanagementsystem.application.Contracts.User.UserClaims;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.UserClaim
{
    public static  class VerifyClaimExtension
    {
        public static void  VerifyClaim(this IServiceCollection services)
        {
            services.AddScoped<IVerifyClaim, VerifyClaim>();
        }
    }
}
