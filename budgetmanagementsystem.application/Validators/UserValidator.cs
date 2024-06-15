using budgetmanagementsystem.application.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Validators
{
    public  class UserValidator:AbstractValidator<AppUser>
    {
        public UserValidator() {

            RuleFor(u=>u.Email).NotNull().NotEmpty().WithMessage("{PropertyName} must not Empty");
            RuleFor(u=>u.FirstName).NotNull().NotEmpty().WithMessage("{PropertyName} must not Empty");
            RuleFor(u => u.LastName).NotNull().NotEmpty().WithMessage("{PropertyName} must not Empty");
            RuleFor(u => u.Password).NotNull().NotEmpty().WithMessage("{PropertyName} must not Empty");
        }
    }
}
