using budgetmanagementsystem.application.Contracts.Specifications.Client.Expense;
using budgetmanagementsystem.application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.infrastructure.expense.expenses.Filter
{
    public class Filter : IFilter
    {
        public Filter() {
         
        }
        public IEnumerable<UserExpense> GetUserExpenseByThreeMonths()
        {
          throw new NotImplementedException();
        }
    }
}
