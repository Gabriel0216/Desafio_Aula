using Desafio_Aula.Shared;
using Microsoft.EntityFrameworkCore;

namespace Desafio_Aula.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Produto> Produtos { get; set; }
    }
}