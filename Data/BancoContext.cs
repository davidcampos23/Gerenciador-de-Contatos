using Microsoft.EntityFrameworkCore;
using SistemaDeCadastros.Models;

namespace SistemaDeCadastros.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 

        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
