using budgetmanagementsystem.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.persistence.Configurations
{
    public class ExpenseConfiguration:IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Amount)
                .IsRequired();
            builder.Property(e=>e.Category) .IsRequired();
            builder.Property(e => e.Date);
            builder.HasOne(t => t.User)
                .WithMany(t=>t.Expenses);
                

        }

    }
}
