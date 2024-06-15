using budgetmanagementsystem.application.Contracts.Users.Authenticate;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.Identity.Authenticate
{
    public class Authenticate : IAuthenticate<Login>
    {
        private SignInManager<User> _signInManager { get; set; }
        private UserManager<User> _userManager { get; set; }
        public Authenticate(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;

        }

        public async Task<User> SignInAsync(Login Login)
        {
            User appUser = await _userManager.FindByEmailAsync(Login.Email);

            await _signInManager.PasswordSignInAsync(appUser, Login.Password, false, false);

            return appUser;
        }
        
    }
}
