using System;

namespace AppSempreIT.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string NomeDoProjeto { get; set; }
        public DateTime DataDeInicio { get; set; } 
        public DateTime DataDeConclusao { get; set; }
        public string DataDeCriacaoDoRegistros { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmssffff");
    }
}
