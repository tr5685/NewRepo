using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Users.UserClaims
{
    public  interface IAddUserClaim
    {
        public void AddClaim(budgetmanagementsystem.domain.Entities.User user, Claim claim);
    }
}
