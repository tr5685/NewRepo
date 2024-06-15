using budgetmanagementsystem.application.Contracts.Specifications.Admin.ManageAccounts.ActivateAccount;
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
    public class Activate :BaseRepository, IActivateAccount
    {

        public Activate (budgetmanagementsystemDbContext context):base(context) { }
       public void   ActivateAccount(AppUser appUser)
        {

            var user = new User
            {
                IsAccountedActived = appUser.IsAccountActived
            };
          //  _context.Entry(user).State = Entitype.Modified;
        }
    }
}
