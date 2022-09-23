using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;

namespace Frontend.Pages
{
    public class UserDataModel : PageModel
    {

        private readonly IRepositorioDatosUser repositorioDatosUser;

        public IEnumerable<DatosUser> DatoUser {get;set;}

        public UserDataModel(IRepositorioDatosUser repositorioDatosUser) 
        {
            this.repositorioDatosUser=repositorioDatosUser;
        }

        public void OnGet()
        {
            DatoUser=repositorioDatosUser.GetAll();
        }
    }
}
