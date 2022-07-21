using System;
using System.ComponentModel.DataAnnotations;

namespace AppSempreIT.Models.Dtos
{
    public class ProjetoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatório"), MinLength(3)]
        public string NomeDoProjeto { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeConclusao { get; set; }
        public string DataDeCriacaoDoRegistros { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmssffff");
    }
}
