using FluentValidation;

namespace Rehber.VALIDATORS
{
    public class RehberValidator:AbstractValidator<SINIFLAR.Rehber>
    {
        public RehberValidator()
        {
            RuleFor(x => x.Adi).NotEmpty();
            RuleFor(x => x.Soyadi).NotEmpty();
            RuleFor(x => x.Unvani).NotEmpty();
            RuleFor(x => x.CepTelefonu).NotEmpty();
            RuleFor(x => x.DahiliNo).NotEmpty();
            RuleFor(x => x.GorevYeri).NotEmpty();
        }
    }
}
