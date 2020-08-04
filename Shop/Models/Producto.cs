using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public string Foto { get; set; }

        public ICollection<Stock> Stock { get; set; }
        public ICollection<OrdenProducto> OrdenProductos { get; set; }
    }
}
