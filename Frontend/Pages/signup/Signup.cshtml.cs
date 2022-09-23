using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;

namespace Frontend.Pages
{
    public class SignupModel : PageModel
    {

        private readonly IRepositorioDatosUser repositorioDatosUser;
        [BindProperty]

        public DatosUser DatoUser {get;set;}

        public SignupModel(IRepositorioDatosUser repositorioDatosUser) 
        {
            this.repositorioDatosUser=repositorioDatosUser;
        }

        public void OnGet()
        {
            DatoUser=new DatosUser();
        }

        public IActionResult OnPost()
        {
            repositorioDatosUser.Add(DatoUser);
            return Page();
        }
    }
}
