using budgetmanagementsystem.application.Models;
using budgetmanagementsystem.application.Models.DTo;
using budgetmanagementsystem.application.Validators;
using budgetmanagementsystem.persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace budgetmanagementsystem.api.Controllers
{
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private ExpenseRepository _expenseRepository;
        private ExpenseValidator _expenseValidator;
        public ExpenseController(ExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
            _expenseValidator = new ExpenseValidator();
        }

        [HttpPost("api/Expense/create")]
        public async Task<ActionResult> AddExpense(ExpenseDto expense)
        {
            var result = _expenseValidator.Validate(expense);
            if (result.Errors.Count > 0)
            {
                return BadRequest(result.Errors);
            }
            await  _expenseRepository.AddAsync(expense);


            return CreatedAtAction(nameof(AddExpense), new { amount = expense.Amount });
        }

        [HttpGet("api/Expense")]
        public async Task<IEnumerable<UserExpense>> GetAllExpenseUser()
        {
            return await _expenseRepository.GetAllAsync();
        }
    }
}
