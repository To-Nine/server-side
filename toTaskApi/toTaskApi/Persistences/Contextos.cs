using Microsoft.EntityFrameworkCore;
using toTaskApi.Domain;

namespace toTaskApi.Persistences
{
    public class Contextos : DbContext
    {
        public IConfiguration _config { get; }
        public Contextos(DbContextOptions<Contextos> options, IConfiguration config) : base(options)
        {
            this._config = config;
        }

        DbSet<Organizacoes> Oganizacoes { get; set; }
        DbSet<Projetos> Projetos { get; set; }
        DbSet<Tarefas> Tarefas { get; set; }
        DbSet<Usuarios> Usuarios { get; set; }
        DbSet<UsuariosProjetos> UsuariosProjetos { get; set; }
        DbSet<OrganizacaoUsuarios> OrganizacaoUsuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public string ObterCaminhoConexao()
        {
            return _config.GetConnectionString("ConnectionDb");
        }

    }
}
