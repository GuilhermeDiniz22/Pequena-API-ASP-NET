using Microsoft.EntityFrameworkCore;

namespace exercicio.Models
{
    public partial class bibliotecaContext : DbContext
    {
        public bibliotecaContext(DbContextOptions<bibliotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluno> Aluno { get; set; }
    }
}








