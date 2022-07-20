using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSempreIT.Models.Interface.Repository
{
    public interface IProjetoRepository
    {
        Task<Projeto> Get(int id);
        Task<IList<Projeto>> GetAll();
        Task Post(Projeto projeto);
    }
}
