using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minuta.App.Dominio
{
    public class Residentes
    {
        public int Id {get; set;}

        [Required(ErrorMessage ="Debes de escribir el Documento"), StringLength(50)]
        public string Documento {get;set;}
        [Required(ErrorMessage ="Debes de escribir el Nombre"), StringLength(50)]
        public string Nombre {get;set;}
        [Required(ErrorMessage ="Debes de escribir el Apellido"), StringLength(50)]
        public string Apellido {get;set;}
        [Required(ErrorMessage ="Debes de escribir el Numero de Telefono"), StringLength(50)]
        public string NumeroTelefono {get;set;}
        [Required(ErrorMessage ="Debes de escribir el numero de Apartamento"), StringLength(50)]
        public string Apartamento {get;set;}
    }
}