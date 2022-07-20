using AppSempreIT.Models.Interface.Repository;
using AppSempreIT.Models.Interface.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSempreIT.Models.Service
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;
        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }
        public async Task<Projeto> Get(int id)
        {
           return  await _projetoRepository.Get(id);
        }

        public  async Task<IList<Projeto>> GetAll()
        {
            return await _projetoRepository.GetAll();
        }

        public async Task Post(Projeto projeto)
        {
            await _projetoRepository.Post(projeto);
        }
    }
}
