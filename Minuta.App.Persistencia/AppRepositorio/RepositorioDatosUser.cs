using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorio
{
    public class RepositorioDatosUser : IRepositorioDatosUser
    {
        private AppContext appContext = new AppContext();
     
        public DatosUser Add(DatosUser DatosUserAgregar)
        {
            var AgregarDatos = appContext.DatosUsersDB.Add(DatosUserAgregar);
            appContext.SaveChanges();
            return AgregarDatos.Entity;
        }

        public IEnumerable<DatosUser> GetAll()
        {
            return appContext.DatosUsersDB;
        }

        public DatosUser GetLoginId(int LoginID)
        {
            return appContext.DatosUsersDB.SingleOrDefault(a => a.Id == LoginID);
        }

        public DatosUser Update(DatosUser DatosUserEditar)
        {
            var Datico = appContext.DatosUsersDB.SingleOrDefault(s => s.Id == DatosUserEditar.Id);
            
            if(Datico != null){
                Datico.Nombre = DatosUserEditar.Nombre;
                Datico.Edad = DatosUserEditar.Edad;
            }
            return Datico;
        }

        public void DeleteDatos(int LoginID)
        {
            var DatoUserEncontrado = appContext.DatosUsersDB.FirstOrDefault(d => d.Id == LoginID);
            if(DatoUserEncontrado == null){
                return;
            }
            appContext.DatosUsersDB.Remove(DatoUserEncontrado);
            appContext.SaveChanges();
        }
    }
}