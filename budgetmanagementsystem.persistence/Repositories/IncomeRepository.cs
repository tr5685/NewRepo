using budgetmanagementsystem.application.Contracts.Persistence;
using budgetmanagementsystem.application.Contracts.User.UserClaims;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.application.Models.DTo;
using budgetmanagementsystem.domain.Entities;
using budgetmanagementsystem.infrastructure.income.incomes.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.persistence.Repositories
{
    public class IncomeRepository : BaseRepository, IAsyncIncomeRepository
    {
        private IVerifyClaim _verifyClaim;
        public IncomeRepository(budgetmanagementsystemDbContext context,IVerifyClaim verifyClaim):base(context){ 
            _verifyClaim = verifyClaim;
        }
        public async Task AddAsync(IncomeDto incomeDto)
        {
            var income = new Income
            {
                Amount = incomeDto.Amount,
                Category = incomeDto.Category,
                Date = incomeDto.Date,
                UserId=_verifyClaim.HasUserIdClaim().Value
            };
           await  _context.Incomes.AddAsync(income);
           await  _context.SaveChangesAsync();
        }

        public  async Task<IEnumerable<UserIncome>> GetAllAsync()
        {
            return _context.Incomes.FilterUserIncomeLastThreeMonth(t => t.UserId == _verifyClaim.HasUserIdClaim().Value);
        }
    }
}
