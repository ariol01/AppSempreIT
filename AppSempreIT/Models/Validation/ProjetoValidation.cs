using AppSempreIT.Models.Dtos;
using FluentValidation;

namespace AppSempreIT.Models.Validation
{
    public class ProjetoValidation : AbstractValidator<ProjetoDto>
    {
        public ProjetoValidation()
        {
            RuleFor(x => x.NomeDoProjeto).NotNull().MinimumLength(3).WithMessage("Informe um nome de projeto com a partir de 3 caracteres no mínimo.");
            RuleFor(x => x.ResponsavelPeloProjeto).NotNull().WithMessage("É obrigatório informar o responsável do projeto");
        }
    }
}
