using Entities.Corcretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class ColorValidatoin:AbstractValidator<Color>
    {
        public ColorValidatoin()
        {
            RuleFor(co => co.ColorName).NotEmpty();
            RuleFor(co => co.ColorName).MinimumLength(2);

        }
    }
}
