using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Modelos
{
    public class Producto
    {


        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescProducto { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string Foto { get; set; }
        public int Destacado { get; set; }
        public string UnidadMedida { get; set; }
        public decimal? Stock { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int EstadoProducto { get; set; }
        public string Comentarios { get; set; }
    }
}