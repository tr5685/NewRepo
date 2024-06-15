using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Users.Authenticate
{
    
        public interface IAuthenticate<TUser> where TUser : class
        {
            public Task<budgetmanagementsystem.domain.Entities.User> SignInAsync(TUser User);

        }
    
}
