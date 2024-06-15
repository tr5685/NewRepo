using budgetmanagementsystem.domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.persistence
{
    public class budgetmanagementsystemDbContext:IdentityDbContext<User>
    {

        public DbSet<Expense> Expenses {  get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<User> Users {  get; set; }
        public budgetmanagementsystemDbContext(DbContextOptions<budgetmanagementsystemDbContext> options) :base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.ApplyConfigurationsFromAssembly(typeof(budgetmanagementsystemDbContext).Assembly);
            
            base.OnModelCreating(ModelBuilder);
        }
        

        
    }
}
