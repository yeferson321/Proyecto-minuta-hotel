using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Console
{
    class program
    {
        private static IRepositorioDatosUser _repoDatos= new RepositorioDatosUser(new AplicacionWeb.Persistencia.AppRepositorios.AppContext()); 

        static void Main(string[] args){
            AddDatos();
        }

        private static void AddDatos()
        {
            var usuario = new Usuario
            {
                Id = 0,
                email = "131elyefer@gmail.com",
                password = "e3fer4t5f"
            };

            _repoDatos.AddDatos(usuario);
        }
    }
}
