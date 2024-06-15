using budgetmanagementsystem.application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Persistence
{
    public interface  IAsyncUserRepository
    {
        public Task AddUserAsync(AppUser appUser);
    }
}
