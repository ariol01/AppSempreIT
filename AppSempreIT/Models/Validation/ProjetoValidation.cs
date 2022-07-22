using AppSempreIT.Models.Dtos;
using FluentValidation;

namespace AppSempreIT.Models.Validation
{
    public class ProjetoValidation : AbstractValidator<ProjetoDto>
    {
        public ProjetoValidation()
        {
            RuleFor(x => x.NomeDoProjeto).NotNull().MinimumLength(3).WithMessage("Informe um nome de projeto com a partir de 3 caracteres no mínimo.");
            RuleFor(x => x.ResponsavelPeloProjeto).NotNull().WithMessage("É obrigatório informar o responsável do projeto.");
            RuleFor(x => x.DataDeInicio).NotEmpty().WithMessage("É obrigatório informar a data de início.");
            RuleFor(x => x.DataDeConclusao).NotEmpty().WithMessage("É obrigatório informar a data de conclusão.");
        }
    }
}
