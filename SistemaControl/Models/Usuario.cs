using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaControl.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Nombre requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Apellido requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Dni requerido")]
        public int Dni { get; set; }
    }
}