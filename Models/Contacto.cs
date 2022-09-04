using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIZZERIA.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        [Display(Name = "Nombres y Apellidos", Prompt ="Ingresa tu nombre")]
        public string? Nombre{get; set; }

        [Column("correo")]
        [EmailAddress]
        [Display(Name = "Correo Electronico", Prompt = "example@example.org")]
        public string? Email {get; set; }
        
        [Column("telefono")]
        [Phone]
        [Display(Name = "Telefono",Prompt = "999-999-999")]
        public string? Telefono {get; set; }
        
        [Column("comentario")]
        [MinLength(5)]
        [MaxLength(1024)]
        [Display(Name = "Comentario",Prompt="Escribe tu comentario")]
        public string? Comentario {get; set; }
    }
}