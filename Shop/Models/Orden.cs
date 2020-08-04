using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Orden
    {
        [Key]
        public int Id { get; set; }

        public Cliente Cliente { get; set; }
        public string OrdenRef { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        [Display(Name = "Codigo Postal")]
        public string CodigoPostal { get; set; }

        public ICollection<OrdenProducto> OrdenProductos { get; set; }
    }

    public class OrdenViewModel : Orden
    {
        public int ClienteId { get; set; }
        public int[] Products { get; set; }
    }
}
