using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Persistencia.AppRepositorio;
using Minuta.App.Dominio;

namespace Minuta.App
{
    public class LoginModel : PageModel
    {
        private readonly IRepositorioDatosUser repositorioDatosUser;
        public IEnumerable<DatosUser> DatosUsser{get;set;}
        public LoginModel(IRepositorioDatosUser repositorioDatosUser){
            this.repositorioDatosUser = repositorioDatosUser;
        }
        public void OnGet()
        {
            DatosUsser = repositorioDatosUser.GetAll();
        }
    }
} 
