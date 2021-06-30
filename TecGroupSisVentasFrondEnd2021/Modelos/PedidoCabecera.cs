using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Modelos
{
    public class PedidoCabecera
    {
        
        public int IdPedidoCab { get; set; }
        
        public int IdUsuario { get; set; }
        
        public string NombreCli { get; set; }
        
        public DateTime? FechaPedido { get; set; }
        
        public int? IdCupon { get; set; }
        
        public decimal? SubTotal { get; set; }
        
        public decimal? IGV { get; set; }
        
        public decimal? SubTotal2 { get; set; }
        
        public decimal? Descuentos { get; set; }
        
        public decimal? Total { get; set; }
        
        public decimal? MonEnvio { get; set; }
        
        public decimal? TotalmasEnvio { get; set; }
        
        public string TipoPago { get; set; }
        
        public string TipoPedido { get; set; }
        
        public string EstadoPedido { get; set; }
        
        public int? Estado { get; set; }
        
        public List<CartItems> detalle { get; set; }
      public List<PedidoDetalle> detalle2 { get; set; }

        public PedidoCabecera()
        {

        }
    }
}