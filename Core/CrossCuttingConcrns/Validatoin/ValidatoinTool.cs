using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcrns.Validatoin
{
  public static  class ValidatoinTool
    {
        public static void Validate(IValidator  validator ,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (! result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
