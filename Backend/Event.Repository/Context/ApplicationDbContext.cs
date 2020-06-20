using Event.Domain;
using Microsoft.EntityFrameworkCore;

namespace Event.Repository.Context
{
    public class ApplicationDbcontext : DbContext
    {
        public DbSet<Asistencia> Asistencias {get;set;}
        public DbSet<Conductor> Conductores {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
        public DbSet<CatBrevete> CatBrevetes {get;set;}
        public DbSet<Administrador> Administradores {get;set;}
        public DbSet<Brevete> Brevetes {get;set;}
        public DbSet<CatUsuario> CatUsuarios {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
        protected ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }
    }
}