using budgetmanagementsystem.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagement.Admin.Account
{
    public class BaseRepository
    {
        protected budgetmanagementsystemDbContext _context;
        public BaseRepository(budgetmanagementsystemDbContext context)
        {
            _context = context;
        }
    }
}
