using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Persistencia.AppRepositorios
{
    public class RepositorioDatosUser : IRepositorioDatosUser
    {

        private readonly AppContexto _appContexto;

        public RepositorioDatosUser(AppContexto appContexto)
        {
            DatoUser = new List<DatosUser>()
            {
                new DatosUser{Id=1, Email="131elyefer@gmail.com", Password="234235F323RD2"},
                new DatosUser{Id=2, Email="apiuserdeploy@gmail.com", Password="FW4RG45YG4"},
            };

            _appContexto = appContexto;
        }

        Usuario IRepositorioDatosUser.AddDatos(Usuario usuario)
        {
            Console.WriteLine("hola");
            var datoAdicionado= _appContexto.Usuarios.Add(usuario);
            _appContexto.SaveChanges();
            return datoAdicionado.Entity;
        }

        List<DatosUser> DatoUser;

        public DatosUser AddDB(DatosUser NewUser)
        {
            //ConexionSQL c = new ConexionSQL();
            Console.WriteLine("hola");
            Console.WriteLine(NewUser.Email);
            Console.WriteLine(NewUser.Password);
            return NewUser;
        }

        public DatosUser Add(DatosUser NuevoDatoUser)
        {
            NuevoDatoUser.Id = DatoUser.Max(r => r.Id) + 1;
            DatoUser.Add(NuevoDatoUser);
            return NuevoDatoUser;
        }

        public IEnumerable<DatosUser> GetAll()
        {
            return DatoUser;
        }

        public DatosUser AddUser(DatosUser NuevoUser)
        {
            return NuevoUser;
        }

        public DatosUser GetDatoUserPorId(int DatoUserId)
        {
            return DatoUser.SingleOrDefault(d => d.Id == DatoUserId);
        }



    }
}