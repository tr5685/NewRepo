using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using budgetmanagementsystem.application.Contracts.Specifications.Client.Income;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace budgetmanagementsystem.infrastructure.income.incomes.Filter
{
    public static class FilterExtension
    {
        public static IServiceCollection AddIncomeService(this IServiceCollection services)
        {
            services.AddScoped<IFilter, Filter>();
            return services;
        }
        public static IEnumerable<UserIncome> FilterUserIncomeLastThreeMonth(this DbSet<Income> incomes, Func<Income, bool> income)
        {

            var query = incomes
                .Include(e => e.User)
                .Where(income)
                .Select(t => new UserIncome
                {
                    IdIncome = t.Id,
                    UserId = t.UserId,
                    Amount = t.Amount,
                    Category = t.Category,
                    Date = t.Date,
                    Firstname = t.User.FirstName,
                    Lastname = t.User.LastName,

                });
            return query.ToList();


        }
    }
}
