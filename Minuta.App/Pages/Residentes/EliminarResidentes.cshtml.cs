using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class EliminarResidentesModel : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        public EliminarResidentesModel(IRepositorioResidente repositorioResidente)
        {
            this.repositorioResidente = repositorioResidente;
        }
        public IActionResult OnGet(int ResidenteID)
        {
            repositorioResidente.DeleteResidente(ResidenteID);
            return RedirectToPage("./ListaResidentes");
        }
    }
}
