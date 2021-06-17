﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Models
{
    public class Cliente

    { 
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public int? idDistrito { get; set; }
        public string NomDistrito { get; set; }
        public string Direccion { get; set; }
        public string DNI { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public decimal? Saldo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? EstadoCliente { get; set; }
    }
}
