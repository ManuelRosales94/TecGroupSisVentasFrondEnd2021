namespace TecGroupSisVentasFrondEnd2021
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class CartItems
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public int Producto_IdProducto { get; set; }

        public string Producto_NombreProducto { get; set; }

        public string Producto_DescProducto { get; set; }

        public decimal? Producto_PrecioCompra { get; set; }

        public decimal? Producto_PrecioVenta { get; set; }

        public string Producto_Foto { get; set; }

        public int Producto_Destacado { get; set; }

        public string Producto_UnidadMedida { get; set; }

        public decimal? Producto_Stock { get; set; }

        public int Producto_IdCategoria { get; set; }

        public string Producto_Categoria { get; set; }

        public DateTime? Producto_FechaRegistro { get; set; }

        public int Producto_EstadoProducto { get; set; }

        public string Producto_Comentarios { get; set; }
    }
}
