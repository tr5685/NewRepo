using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.User.UserClaims
{
    public interface IVerifyClaim
    {
        public Claim HasUserIdClaim();
        public Claim HasAdminClaim();
    }
}
