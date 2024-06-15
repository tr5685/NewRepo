using budgetmanagementsystem.application.Models.DTo;
using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.application.Validators;
using budgetmanagementsystem.persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace budgetmanagementsystem.api.Controllers
{
    
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private IncomeRepository _incomeRepository;
        private IncomeValidator _incomeValidator;
        public IncomeController(IncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
            _incomeValidator = new IncomeValidator();
        }

        [HttpPost("api/Income/create")]
        public async Task<ActionResult> AddIncome(IncomeDto income)
        {
            var result = _incomeValidator.Validate(income);
            if (result.Errors.Count > 0)
            {
                return BadRequest(result.Errors);
            }
            await _incomeRepository.AddAsync(income);


            return CreatedAtAction(nameof(AddIncome), new { amount = income.Amount });
        }

        [HttpGet("api/Income")]
        public async Task<IEnumerable<UserIncome>> GetAllExpenseUser()
        {
            return await _incomeRepository.GetAllAsync();
        }
    }
}
