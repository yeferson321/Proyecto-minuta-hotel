using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;

namespace Frontend.Pages
{
    public class FormModel : PageModel
    {
        private static IRepositorioDatosUser _repoDatos= new RepositorioDatosUser(new AplicacionWeb.Persistencia.AppRepositorios.AppContext()); 

        private readonly IRepositorioDatosUser repositorioDatosUser;
        [BindProperty]
        public Usuario usuario {get;set;}

        public FormModel(IRepositorioDatosUser repositorioDatosUser) 
        {
            this.repositorioDatosUser=repositorioDatosUser;
        }

        public void OnGet()
        {
            usuario=new Usuario(); 
        }

        public IActionResult OnPost()
        {
            _repoDatos.AddDatos(usuario);
            return Page();
        }
        
    }
}
