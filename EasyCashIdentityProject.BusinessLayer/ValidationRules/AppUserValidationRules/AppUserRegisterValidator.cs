using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Boş geçilemez");

            
        }
    }
}
