using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
