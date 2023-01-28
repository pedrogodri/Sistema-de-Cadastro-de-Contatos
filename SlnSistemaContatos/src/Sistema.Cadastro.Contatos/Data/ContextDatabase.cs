using Microsoft.EntityFrameworkCore;
using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Data
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options)
            : base(options) { }

        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
