using System.Runtime.ConstrainedExecution;
using FluentValidation;

namespace DevIO.Business.Models.Validations
{
	public class EnderecoValidation : AbstractValidator<Endereco>
    {
		public EnderecoValidation()
		{
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("0 campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("0 campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("0 campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("0 campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Cep)
                .NotEmpty().WithMessage("0 campo {PropertyName} precisa ser fornecido")
                .Length(8).WithMessage("0 campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("A campo {PropertyName} precisa ser fornecida")
                .Length(2, 100).WithMessage("0 campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("0 campo {PropertyName} precisa ser fornecido")
                .Length(2, 50).WithMessage("0 campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("0 campo {PropertyName} precisa ser fornecido")
                .Length(1, 50).WithMessage("0 campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
	}
}

