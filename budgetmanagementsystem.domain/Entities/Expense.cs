using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.domain.Entities
{
    public  class Expense
    {
        public int Id { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date {  get; set; }
        public string Category { get; set; }=string.Empty;
        public User User { get; set; } = null!;
        public string UserId { get; set; } =string.Empty;
    }
}
