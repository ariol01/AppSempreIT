using AppSempreIT.Infra.Context;
using AppSempreIT.Models;
using AppSempreIT.Models.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppSempreIT.Infra.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly DataContext _context;
        public ProjetoRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Projeto> Get(int id)
        {
            return await _context.Projetos.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<IList<Projeto>> GetAll()
        {
            return await _context.Projetos.ToListAsync();
        }

        public async Task Post(Projeto projeto)
        {
            await _context.Projetos.AddAsync(projeto);
            await _context.SaveChangesAsync();
        }
    }
}
