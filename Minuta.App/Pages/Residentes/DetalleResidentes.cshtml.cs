using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class DetalleResidentesModel : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;

        public Residentes residenteDetalle {get;set;}
        public DetalleResidentesModel(IRepositorioResidente repositorioResidente){
            this.repositorioResidente = repositorioResidente;

        }

        public IActionResult OnGet(int ResidenteID)
        {
            residenteDetalle = repositorioResidente.GetResidenteId(ResidenteID);
            if(residenteDetalle == null)
            {
                return RedirectToPage("./ListaResidentes");
            }else
                return Page();
        }
    }
}
