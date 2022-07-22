namespace AppSempreIT.Models.Dtos
{
    public static  class ProjetoFactory
    {
        public static Projeto Criar(ProjetoDto projetoDto)
        {
            return new Projeto
            {
                NomeDoProjeto = projetoDto.NomeDoProjeto,
                ResponsavelPeloProjeto = projetoDto.ResponsavelPeloProjeto,
                DataDeInicio = projetoDto.DataDeInicio.Date,
                DataDeConclusao = projetoDto.DataDeConclusao.Date, 
                DataDeCriacaoDoRegistros = projetoDto.DataDeCriacaoDoRegistros,                                
            };
        }
    }
}
