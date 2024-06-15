using budgetmanagementsystem.application.Contracts.Specifications.Admin.ManageAccounts.DesactivateAccount;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.domain.Entities;
using budgetmanagementsystem.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagement.Admin.Account
{
    public class Desactivate :BaseRepository, IDesactivateAccount {

        public Desactivate(budgetmanagementsystemDbContext context) : base(context) { }
        public void DesactivateAccount(AppUser appUser)
        {

            var user = new User
            {
                IsAccountedActived = appUser.IsAccountActived
            };
            
            
        }
    }
}
