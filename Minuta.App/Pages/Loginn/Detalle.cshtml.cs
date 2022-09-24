using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Persistencia.AppRepositorio;
using Minuta.App.Dominio;

namespace Minuta.App
{
    
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioDatosUser repositorioDatosUser;
        public DatosUser DatosUserDetalle{get;set;}
        public DetalleModel(IRepositorioDatosUser repositorioDatosUser){
            this.repositorioDatosUser = repositorioDatosUser;

        }
        public IActionResult OnGet(int LoginID)
        {
            DatosUserDetalle = repositorioDatosUser.GetLoginId(LoginID);
            if(DatosUserDetalle == null)
            {
                return RedirectToPage(":./Login");
            }else
                return Page();
        }
    }     
}
