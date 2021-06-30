using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Modelos
{
    public class PedidoDetalle
    {
        
        public int IdPedidoDet { get; set; }
        
        public int IdPedidoCab { get; set; }
        
        public int IdProducto { get; set; }
        
        public string NombreProd { get; set; }
        
        public int? IdCupon { get; set; }
        
        public int? Cantidad { get; set; }
        
        public decimal? PrecioUnidad { get; set; }
        
        public decimal? PrecioDescuento { get; set; }
        
        public decimal? Total { get; set; }

        
        public DateTime? FechaRegistro { get; set; }

        public string ItemId { get; set; }
       
    }
}