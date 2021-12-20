using Entities.Corcretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class CustomerValidation:AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(cu => cu.CompanyName).NotEmpty();
            RuleFor(cu => cu.CompanyName).MinimumLength(2);
           
        }
    }
}
