using budgetmanagementsystem.application.Contracts.User.UserClaims;
using budgetmanagementsystem.application.Contracts.Users.UserClaims;
using budgetmanagementsystem.domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.UserClaim
{
    public class AddUserClaim : IAddUserClaim
    {
        private UserManager<User> _userManager;
        public AddUserClaim(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public void AddClaim(User user, Claim claim)
        {
            _userManager.AddClaimAsync(user, claim);
        }

        
    }
}
