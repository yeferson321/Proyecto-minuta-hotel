using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionWeb.Persistencia.AppRepositorios;
using AplicacionWeb.Dominio;
using System;
using System.Collections.Generic;

namespace Frontend.Pages
{
    public class DetailsIdModel : PageModel
    {
        private readonly IRepositorioDatosUser repositorioDatosUser;
        
        public DatosUser DatoUser {get;set;}

        public DetailsIdModel(IRepositorioDatosUser repositorioDatosUser)
        {
            this.repositorioDatosUser=repositorioDatosUser;
        }

        public IActionResult OnGet(int DatoUserId)
        {

            DatoUser=repositorioDatosUser.GetDatoUserPorId(DatoUserId);

            if (DatoUser==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}
