using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Persistencia.AppRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {

        private AppContexto _appContexto = new AppContexto();


        Usuario IRepositorioUsuario.AddDatos(Usuario usuario)
        {
            Console.WriteLine("hola");
            var datoAdicionado= _appContexto.Usuarios.Add(usuario);
            _appContexto.SaveChanges();
            return datoAdicionado.Entity;
        }

    }
}