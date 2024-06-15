using budgetmanagementsystem.application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Specifications.Client.Income
{
    public interface IFilter
    {
        public IEnumerable<UserIncome> GetUserIncomeByThreeMonths();
    }
}
