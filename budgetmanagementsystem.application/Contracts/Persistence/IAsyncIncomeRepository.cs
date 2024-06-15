using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.application.Models.DTo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Contracts.Persistence
{
    public  interface IAsyncIncomeRepository
    {

        public Task AddAsync(IncomeDto incomeDto);
        public Task<IEnumerable<UserIncome>> GetAllAsync();
    }
}
