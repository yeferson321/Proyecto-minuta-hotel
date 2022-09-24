using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia.AppRepositorio;

namespace Minuta.App
{
    public class ListaResidentesModel : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        public IEnumerable<Residentes> residentes{get;set;}
        public ListaResidentesModel(IRepositorioResidente repositorioResidente)
        {
            this.repositorioResidente = repositorioResidente;
        }
        public void OnGet()
        {
            residentes = repositorioResidente.GetAllResidente();
        }
    }
}
