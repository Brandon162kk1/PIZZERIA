using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIZZERIA.Models
{
    [Table("t_consultas")]
    public class Consultas
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public String UserID { get; set; }
        public String Email { get; set; } 
        public Contacto Comentario { get; set; }

         public Byte [] archivo {get; set;} = new Byte[1];
        
    }
}