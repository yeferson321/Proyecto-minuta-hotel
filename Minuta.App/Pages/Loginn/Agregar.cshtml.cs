using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioDatosUser repositorioDatosUser;
        [BindProperty]
        public DatosUser DatosUserDetalle {get; set;}
        public AgregarModel(IRepositorioDatosUser repositorioDatosUser)
        {
            this.repositorioDatosUser = repositorioDatosUser;
        }
        public IActionResult OnGet(int ? ResidenteID)
        {
            if(ResidenteID.HasValue){
                DatosUserDetalle = repositorioDatosUser.GetLoginId(ResidenteID.Value);
            }else
                DatosUserDetalle = new DatosUser();

            if(DatosUserDetalle == null){
                return RedirectToPage("./Login");

            }else
                return Page();
        }
        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(DatosUserDetalle.Id > 0){
                DatosUserDetalle = repositorioDatosUser.Update(DatosUserDetalle);
            }else
                repositorioDatosUser.Add(DatosUserDetalle);

                return RedirectToPage("./Login");
        }
    }
}
