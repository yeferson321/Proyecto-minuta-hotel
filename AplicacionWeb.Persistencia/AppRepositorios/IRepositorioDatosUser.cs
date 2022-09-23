using System;
using System.Collections.Generic;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Persistencia.AppRepositorios
{
    public interface IRepositorioDatosUser
    {
        IEnumerable<DatosUser> GetAll();  

        //IEnumerable<DatosUser> GetAllDatos();  

        Usuario AddDatos(Usuario usuario); 
 
        DatosUser GetDatoUserPorId(int DatoUserID);

        DatosUser Add(DatosUser NuevoDatoUser);

        DatosUser AddDB(DatosUser NewUser);

        DatosUser AddUser(DatosUser NuevoUser);
    }
}