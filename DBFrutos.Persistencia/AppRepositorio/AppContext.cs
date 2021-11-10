using System;
using Microsoft.EntityFrameworkCore;
using DBFrutos.Dominio;

namespace DBFrutos.Persistencia
{
    public class AppContext : DBContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=DataBaseFrutos; Data Source=MANAPRRCLFSD625\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}
