using budgetmanagementsystem.application.Contracts.Persistence;
using budgetmanagementsystem.application.Contracts.User.UserClaims;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.application.Models.DTo;
using budgetmanagementsystem.domain.Entities;
using budgetmanagementsystem.infrastructure.expense.expenses.Filter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.persistence.Repositories
{
    public class ExpenseRepository :BaseRepository, IAsyncExpenseRepository
    {
        private IVerifyClaim _verifyClaim;
        public ExpenseRepository(budgetmanagementsystemDbContext context,IVerifyClaim verifyClaim) :base(context){
            _verifyClaim = verifyClaim;
        }
        public async Task AddAsync(ExpenseDto expenseDto)
        {
            var expense = new Expense
            {
                Amount = expenseDto.Amount,
                Date= expenseDto.Date,
                Category= expenseDto.Category,
                UserId=_verifyClaim.HasUserIdClaim().Value
            };
            
            _context.Expenses.Add(expense);
           await _context.SaveChangesAsync();   
        }

        public async Task<IEnumerable<UserExpense>> GetAllAsync()
        {
           return  _context.Expenses.FilterUserExpenseLastThreeMonth(t => t.UserId == _verifyClaim.HasUserIdClaim().Value);
         
        }
    }
}
