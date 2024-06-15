using budgetmanagementsystem.application.Contracts.Persistence;
using budgetmanagementsystem.application.Contracts.Users.UserClaims;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.persistence.Repositories
{
    public class UserRepository :BaseRepository,IAsyncUserRepository
    {
        private UserManager<User> _userManager;
        private IAddUserClaim _addUserClaim;
        public UserRepository(budgetmanagementsystemDbContext context,UserManager<User> userManager,IAddUserClaim addUserClaim):base(context) { 
            _userManager = userManager;
            _addUserClaim = addUserClaim;
        }
        public async Task AddUserAsync(AppUser appUser)
        {
            var user = new User
            {
                Email = appUser.Email,
                PasswordHash = appUser.Password,
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                UserName = appUser.Email
            };
            Claim claim = new Claim("UserId",user.Id);
            await _userManager.CreateAsync(user, appUser.Password);
             _addUserClaim.AddClaim(user, claim);
            await _context.SaveChangesAsync();  
           
        }
       
    }
}
