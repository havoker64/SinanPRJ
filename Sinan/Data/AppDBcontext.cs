using Microsoft.EntityFrameworkCore;
using Sinan.Models;

namespace Sinan.Data
{
    public class AppDBcontext:DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {   }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Notificacao> Notificacoes { get; set; }
    }
}
