using Entities.Corcretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class UserValidatoin : AbstractValidator<User>
    {
        public UserValidatoin()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MinimumLength(2);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(u => u.UserName).MinimumLength(2);
            RuleFor(u => u.UserLastName).NotEmpty();
            RuleFor(u => u.UserLastName).MinimumLength(2);

           
        }
    }
    
}
