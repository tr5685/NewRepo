using budgetmanagementsystem.application.Contracts.Specifications.Client.Income;
using budgetmanagementsystem.application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.income.incomes.Filter
{
    public class Filter : IFilter
    {
        public IEnumerable<UserIncome> GetUserIncomeByThreeMonths()
        {
            throw new NotImplementedException();
        }
    }
}
