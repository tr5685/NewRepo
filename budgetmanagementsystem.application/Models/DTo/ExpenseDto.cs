using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Models.DTo
{
    public  class ExpenseDto
    {
        public int Id { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
