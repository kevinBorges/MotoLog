using FluentValidation;

namespace MotoLog.Business.Entity.Validations
{
    public class MotoValidation : AbstractValidator<Moto>
    {
        public MotoValidation()
        {
            RuleFor(x => x.Plate)
                .NotEmpty()
                    .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(7)
                    .WithMessage("O campo {PropertyName} precisa ter {MaxLength}");

            RuleFor(x => x.Model)
                .NotEmpty()
                    .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 50)
                    .WithMessage("O campo {PropertyName} precisa ter entr {MinLength} e {MaxLength}");

            RuleFor(x => x.Year)
                .NotEmpty()
                    .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(4)
                    .WithMessage("O campo {PropertyName} precisa ter {MaxLength}");
        }


    }
}
