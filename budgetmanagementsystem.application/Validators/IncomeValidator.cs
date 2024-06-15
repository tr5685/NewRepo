using budgetmanagementsystem.application.Models.DTo;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Validators
{
    public  class IncomeValidator:AbstractValidator<IncomeDto>
    {
        public IncomeValidator() {
            RuleFor(e => e.Amount).NotNull()
               .NotEmpty().WithMessage("{PropertyName} must not empty")
               .GreaterThan(0).WithMessage("the amount must greater than zero");

            RuleFor(e => e.Category).NotNull()
                .NotEmpty().WithMessage("{PropertyName} must not empty");
        }
    }
}
