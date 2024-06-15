using budgetmanagementsystem.application.Contracts.Persistence;
using budgetmanagementsystem.application.Contracts.Users.Authenticate;
using budgetmanagementsystem.application.Contracts.Users.Token;
using budgetmanagementsystem.application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace budgetmanagementsystem.api.Controllers
{
    
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAsyncAdminRepository _adminRepository;
        private readonly IAuthenticate<Login> _authenticate;
        private readonly IGenerateToken _generateToken;

        public AdminController(IAsyncAdminRepository adminRepository, IAuthenticate<Login> authenticate, IGenerateToken generateToken)
        {
            _adminRepository = adminRepository;
            _authenticate = authenticate;
            _generateToken = generateToken;
        }

        [HttpPost("/api/[controller]/sign up")]
        public async Task<ActionResult<AppUser>> CreateUser(AppUser appUser)
        {
            await _adminRepository.AddAdmin(appUser);

            return CreatedAtAction(nameof(CreateUser), new { email = appUser.Email });
        }



        [HttpPost("/api/[controller]/sign in")]
        public async Task<ActionResult<string>> Login(Login Login)
        {
            var user = await _authenticate.SignInAsync(Login);
            if (user != null)
            {


                return _generateToken.CreateToken(User.Claims);
            }
            return Unauthorized();

        }
    }
}
