using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PIZZERIA.Models
{
    public class Contacto
    {
        [Display(Name = "Nombres y Apellidos", Prompt ="Ingresa tu nombre")]
        public string? Nombre{get; set; }

        [EmailAddress]
        [Display(Name = "Correo Electronico", Prompt = "example@example.org")]
        public string? Email {get; set; }

        [Phone]
        [Display(Name = "Telefono",Prompt = "999-999-999")]
        public string? Telefono {get; set; }
        
        [MinLength(5)]
        [MaxLength(1024)]
        [Display(Name = "Comentario",Prompt="Escribe tu comentario")]
        public string? Comentario {get; set; }
    }
}