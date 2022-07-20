using AppSempreIT.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSempreIT.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}
