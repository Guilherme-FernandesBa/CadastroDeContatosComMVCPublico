using Microsoft.EntityFrameworkCore;
using CadastroContatosMVC.Models;

namespace CadastroContatosMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {

        } 
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
