using Microsoft.EntityFrameworkCore;
using Sinan.Models;
using System.Composition;

namespace Sinan.Data
{
    public class AppDBcontext:DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {   }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Notificacao> Notificacoes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
