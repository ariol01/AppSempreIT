using AppSempreIT.Models;
using AppSempreIT.Models.Interface.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSempreIT.Infra.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        //private readonly;
        public ProjetoRepository()
        {

        }

        public Task<Projeto> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Projeto>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Post(Projeto projeto)
        {
            throw new System.NotImplementedException();
        }
    }
}
