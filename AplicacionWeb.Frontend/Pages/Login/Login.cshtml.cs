using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;

namespace AplicacionWeb.Frontend.Pages
{
    public class LoginModel : PageModel
    {
        private static IRepositorioUsuario _repoDatos= new RepositorioUsuario(new AplicacionWeb.Persistencia.AppRepositorios.AppContext()); 

        private readonly IRepositorioUsuario repositorioUsuario;
        [BindProperty]
        public Usuario usuario {get;set;}

        public FormModel(IRepositorioUsuario repositorioUsuario) 
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
