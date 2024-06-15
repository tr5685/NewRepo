using budgetmanagementsystem.application.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Specifications.Client.Expense
{
   public interface  IFilter
    {
        public IEnumerable<UserExpense> GetUserExpenseByThreeMonths();
    }
}
