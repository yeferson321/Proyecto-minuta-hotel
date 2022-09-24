using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class EditarResidentesModel : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        [BindProperty]
        public Residentes residenteDetalle {get; set;}
        public EditarResidentesModel(IRepositorioResidente repositorioResidente)
        {
            this.repositorioResidente = repositorioResidente;
        }
        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(residenteDetalle.Id > 0){
                residenteDetalle = repositorioResidente.UpdateResidente(residenteDetalle);
            }else
                repositorioResidente.AddResidente(residenteDetalle);

                return RedirectToPage("./ListaResidentes");
        }
        public IActionResult OnGet(int ? ResidenteID)
        {
            if(ResidenteID.HasValue){
                residenteDetalle = repositorioResidente.GetResidenteId(ResidenteID.Value);
            }else
                residenteDetalle = new Residentes();

            if(residenteDetalle == null){
                return RedirectToPage("./ListaResidentes");

            }else
                return Page();
        }
        
    }
}
