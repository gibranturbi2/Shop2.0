using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Orden> Ordens { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<OrdenProducto> OrdenProductos { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}
