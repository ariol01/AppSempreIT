using AppSempreIT.Models.Dtos;
using AppSempreIT.Models.Helpers;
using AppSempreIT.Models.Interface.Service;
using AppSempreIT.Models.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppSempreIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetoController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }
        // GET: api/<ProjetoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var projetos = await _projetoService.GetAll();

            if (!projetos.Any())
            {
                return NotFound("Projeto não encontrado.");
            }
            return Ok(projetos);
        }

        // GET api/<ProjetoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var projeto = await _projetoService.Get(id);

            if (projeto is null)
            {
                return NotFound("Projeto não encontrado. Você informou o ID " + id);
            }

            return Ok(projeto);
        }

        // POST api/<ProjetoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProjetoDto projetoDto)
        {
            var result = new ProjetoValidation().Validate(projetoDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(projetoDto);
            }

            if (result.IsValid is false)
            {
                return BadRequest(result.Errors);
            }

            var projeto = ProjetoFactory.Criar(projetoDto);

            await _projetoService.Post(projeto);

            return Ok(projeto);
        }

        // PUT api/<ProjetoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjetoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
