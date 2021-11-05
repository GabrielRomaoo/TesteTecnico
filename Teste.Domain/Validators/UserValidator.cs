using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        
        public void InsertUserValidation(User user)
        {
            RuleFor(user => user.Escolaridade).IsInEnum().WithMessage("Selecione uma escolaridade válida!");
            RuleFor(user => user.DataNascimento).Must(IsValidadeDate).WithMessage("Data inválida!");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Email inválido!");
        }


        private bool IsValidadeDate(DateTime date)
        {
            if(date > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
