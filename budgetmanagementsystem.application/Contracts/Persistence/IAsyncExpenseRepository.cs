using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.application.Models.DTo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Persistence
{
    public  interface IAsyncExpenseRepository
    {
        public Task AddAsync(ExpenseDto expenseDto);
        public Task <IEnumerable<UserExpense>> GetAllAsync();
    }
}
