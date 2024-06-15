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
    public class AdminRepository : BaseRepository,IAsyncAdminRepository
    {
        private UserManager<User> _userManager;
        public AdminRepository(budgetmanagementsystemDbContext context,UserManager<User> userManager):base(context) { 
            _userManager = userManager;

        }
        public async  Task AddAdmin(AppUser appUser)
        {
            var user = new User
            {
                Email = appUser.Email,
                PasswordHash = appUser.Password,
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                UserName = appUser.Email
            };
            
           await _userManager.CreateAsync(user,appUser.Password);
            await _userManager.AddToRoleAsync(user, "Admin");
            await _context.SaveChangesAsync();
        }
    }
}
