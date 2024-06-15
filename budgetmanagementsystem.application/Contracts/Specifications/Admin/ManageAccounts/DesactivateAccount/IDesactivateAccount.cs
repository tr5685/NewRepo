using budgetmanagementsystem.application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Specifications.Admin.ManageAccounts.DesactivateAccount
{
    public interface  IDesactivateAccount
    {
        public void DesactivateAccount(AppUser appUser);
    }
}
