using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspNetMvcRoles.Models;

namespace AspNetMvcRoles.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Funcinario> Funcinario { get; set; }
        public DbSet<AspNetMvcRoles.Models.Setor> Setor { get; set; }
        public DbSet<AspNetMvcRoles.Models.Sedes> Sedes { get; set; }
        public DbSet<AspNetMvcRoles.Models.Regras> Regras { get; set; }
        public DbSet<AspNetMvcRoles.Models.Usuarios> Usuarios { get; set; }
    }
}
