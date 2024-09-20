using First_API.Data.Map;
using First_API.Models;
using Microsoft.EntityFrameworkCore;

namespace First_API.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options) : base(options)
        {
        }  
        
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=DESKTOP-ELNDNE2;database=DB_SistemaTarefas;user=sa;password=Js@153624", new MySqlServerVersion(new Version(8, 0, 39)));
            }
        }
    }
}

