using Entities.Corcretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
 public   class ImageValidation: AbstractValidator<ImageCar>
    {
        public ImageValidation()
        {
            RuleFor(ı => ı.Date).NotEmpty();
            RuleFor(ı => ı.ImagePathCar).NotEmpty();
            RuleFor(ı => ı.ImagePathCar).MinimumLength(7);
        }
    }
}
