using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class TiendaContext : DbContext
    {
        public TiendaContext()
            : base("name=TiendaContext")
        {
        }

        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<TipoProducto> TipoProductoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .Property(e => e.NombreProducto)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.NombreTipoProducto)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoProducto>()
                .HasMany(e => e.Productoes)
                .WithRequired(e => e.TipoProducto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
