using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TecGroupSisVentasFrondEnd2021.Models;

namespace TecGroupSisVentasFrondEnd2021.Modelos
{
    public class CarritoCompras
    {
        public Usuario Usuario { get; set; }
        public IEnumerable<Producto> productos { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public int Igv { get; set; }
        public int Total { get; set; }
    }
}