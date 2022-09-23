using Microsoft.EntityFrameworkCore;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Persistencia.AppRepositorios
{
    public class AppContexto : DbContext{

        public DbSet<Usuario> Usuarios{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = proyect");
            }
        }

    }  
}