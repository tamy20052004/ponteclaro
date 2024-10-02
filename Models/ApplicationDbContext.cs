using Microsoft.EntityFrameworkCore;

namespace RsystemWeb.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<Idiomas> Idioma { get; set; }
        public DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<DeterminarTipoUsuarioProcedure> DeterminarTipoUsarioProcedure{ get; set; }
        public DbSet<Competencias> Competencias { get; set; }
        public DbSet<CandidatoCompetencia> CandidatoCompetencia { get; set; }
        public DbSet<CandidatoCapacitacion> CandidatoCapacitacion { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
       


    }
}
