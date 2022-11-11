namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        public int ProductoID { get; set; }

        [StringLength(100)]
        public string NombreProducto { get; set; }

        public int? Stock { get; set; }

        public int TipoProductoID { get; set; }

        public virtual TipoProducto TipoProducto { get; set; }
    }
}
