using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIZZERIA.Models
{
    [Table("t_promociones")]
    public class Promociones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public string? ImageName { get; set; }
    }
}