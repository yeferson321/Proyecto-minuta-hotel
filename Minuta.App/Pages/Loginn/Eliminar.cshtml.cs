using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class EliminarModel : PageModel
    {
        //private static IRepositorioDatosUser _repoDatos = new RepositorioDatosUser(new Persistencia.AppRepositorio.AppContext());
        private readonly IRepositorioDatosUser repositorioDatosUser;

        public EliminarModel(IRepositorioDatosUser repositorioDatosUser)
        {
            this.repositorioDatosUser = repositorioDatosUser;
        }

        public IActionResult OnGet(int LoginID)
        {
            repositorioDatosUser.DeleteDatos(LoginID);
            return RedirectToPage("./Login");
        }
    }
}
