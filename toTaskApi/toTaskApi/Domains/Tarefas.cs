using System.ComponentModel.DataAnnotations.Schema;

namespace toTaskApi.Domain
{
    public class Tarefas : Entidades
    {
        private string Titulo { get; set; }
        private string Descricao { get; set; }

        [ForeignKey("Usuarios")]
        private int UsuarioResponsavelId { get; set; }

        [ForeignKey("Usuarios")]
        private int UsuarioDelatorId { get; set; }

        [ForeignKey("Projetos")]
        private int ProjetoId { get; set; }

        [ForeignKey("Organizacoes")]
        private int OrganizacaoID { get; set; }

        private int HorasLancadas { get; set; }
        private int Estimativa { get; set; }
        private int Estado { get; set; } = 0;


    }
}
