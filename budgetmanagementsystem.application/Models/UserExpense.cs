using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Models
{
    public  class UserExpense
    {
        public int IdExpense { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } =string.Empty;
        public string UserId {  get; set; }=string.Empty;
        public Decimal Amount  { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
