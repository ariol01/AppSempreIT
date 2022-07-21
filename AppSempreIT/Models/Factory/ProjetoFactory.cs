namespace AppSempreIT.Models.Dtos
{
    public static  class ProjetoFactory
    {
        public static Projeto Criar(ProjetoDto projetoDto)
        {
            return new Projeto
            {
                NomeDoProjeto = projetoDto.NomeDoProjeto,
                DataDeInicio = projetoDto.DataDeInicio,
                DataDeConclusao = projetoDto.DataDeConclusao, 
                DataDeCriacaoDoRegistros = projetoDto.DataDeCriacaoDoRegistros,                                
            };
        }
    }
}
