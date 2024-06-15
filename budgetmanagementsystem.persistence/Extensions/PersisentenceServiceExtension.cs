using budgetmanagementsystem.application.Contracts.Persistence;
using budgetmanagementsystem.persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.persistence.Extensions
{
    public static  class PersisentenceServiceExtension
    {
        public static IServiceCollection AddServicePersistence(this IServiceCollection Services,IConfiguration Configuration)
        {
            Services.AddDbContext<budgetmanagementsystemDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("connectionString")));
            
            Services.AddScoped<IAsyncExpenseRepository,ExpenseRepository>();
            Services.AddScoped<IAsyncIncomeRepository,IncomeRepository>();
            Services.AddScoped<IAsyncUserRepository, UserRepository>();
            return Services;
        }
    }
}
