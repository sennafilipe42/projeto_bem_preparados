using FluentValidation;
using Domain.Entities;
using System;

namespace Domain.Validators
{
    public class UsuarioValidador : AbstractValidator<UserEntitie>
    {
        public UsuarioValidador()
        {

            //regras da validação se não for o padrão não salva
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.")

                .NotNull()
                .WithMessage("A entidade não pode ser nula.");

            RuleFor(x => x.Usuario)
                .NotEmpty()
                .WithMessage("A usuario não pode ser vazio.")

                .NotNull()
                .WithMessage("A usuario não pode ser nulo")

                .MinimumLength(8)
                .WithMessage("A usuario deve ter no mínimo 8 caracteres.")

                .MaximumLength(14)
                .WithMessage("O nome de ter no mínimo 14 caracteres.");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")

                .NotNull()
                .WithMessage("O nome não pode ser nulo")

                .MinimumLength(3)
                .WithMessage("O nome de ve ter no mínimo 3 caracteres.")

                .MaximumLength(80)
                .WithMessage("O nome de ter no mínimo 80 caracteres.");

            RuleFor(x => x.Senha)
                .NotEmpty()
                .WithMessage("A senha não pode ser vazia.")

                .NotNull()
                .WithMessage("A senha não pode ser nula")

                .MinimumLength(8)
                .WithMessage("A senha deve ter no mínimo 8 caracteres.");


        }

    }
}
