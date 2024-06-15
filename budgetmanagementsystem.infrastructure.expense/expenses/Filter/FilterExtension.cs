using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using budgetmanagementsystem.application.Contracts.Specifications.Client.Expense;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace budgetmanagementsystem.infrastructure.expense.expenses.Filter
{
    public static  class FilterExtension
    {
        public static  IServiceCollection addExpenseService(this IServiceCollection services)
        {
            services.AddScoped<IFilter, Filter>();

            return services;
        }
        public static IEnumerable<UserExpense> FilterUserExpenseLastThreeMonth(this DbSet<Expense> expenses,Func<Expense,bool> expense) {

            var query = expenses
                .Include(e => e.User)
                .Where(expense)
                .Select(t=>new UserExpense
                {
                    IdExpense= t.Id,
                    UserId=t.UserId,
                    Amount=t.Amount,
                    Category=t.Category,
                    Date=t.Date,
                    Firstname=t.User.FirstName,
                    Lastname=t.User.LastName

                });
            return query.ToList();
        }
    }
}
