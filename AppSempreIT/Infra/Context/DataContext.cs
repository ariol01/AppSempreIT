using AppSempreIT.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSempreIT.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Projeto> Projetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>().HasKey(x => x.Id);
            modelBuilder.Entity<Projeto>().Property(x => x.NomeDoProjeto).IsRequired();
            modelBuilder.Entity<Projeto>().Property(x => x.ResponsavelPeloProjeto).IsRequired();           
        }
    }
}
