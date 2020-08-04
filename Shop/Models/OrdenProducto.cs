using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OrdenProducto
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int OrdenId { get; set; }
        public Orden Orden { get; set; }
    }
}
