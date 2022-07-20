using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSempreIT.Models.Interface.Service
{
    public interface IProjetoService
    {
        Task<Projeto> Get(int id);
        Task<IList<Projeto>> GetAll();
        Task Post(Projeto projeto);     

    }
}
