using budgetmanagementsystem.application.Contracts.User.UserClaims;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.UserClaim
{
    public class VerifyClaim : IVerifyClaim
    {
        private IHttpContextAccessor _httpContextAcessor;
        public VerifyClaim(IHttpContextAccessor httpContextAcessor)
        {
            _httpContextAcessor = httpContextAcessor;
        }

        public Claim HasAdminClaim()
        {
            return _httpContextAcessor.HttpContext.User.Claims.First(u => u.Type == "Admin");
        }

        public Claim HasUserIdClaim()
        {
            return _httpContextAcessor.HttpContext.User.Claims.First(u => u.Type == "UserId");
        }
    }
}
