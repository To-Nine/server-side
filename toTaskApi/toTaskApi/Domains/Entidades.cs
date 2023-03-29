using System.ComponentModel.DataAnnotations;

namespace toTaskApi.Domain
{
    public abstract class Entidades
    {
        [Key()]
        private int Id { get; set; }
        private DateTime DataInsercao { get; set; } = DateTime.UtcNow;
        private DateTime? DataExpiracao { get; set; }

        protected void AdicionarDataExpiracao(DateTime dataExpiracao)
        {
            this.DataExpiracao = dataExpiracao;
        }
    }
}
