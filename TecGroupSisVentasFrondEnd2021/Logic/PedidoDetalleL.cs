using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TecGroupSisVentasFrondEnd2021.Modelos;

namespace TecGroupSisVentasFrondEnd2021.Logic
{
    public class PedidoDetalleL
    {
        private BDConexion conn = new BDConexion();
        private SqlCommand cmdDetalleVentas = new SqlCommand();



    public string Insertar(PedidoDetalle item)
    {
        string rpta = "";
        try
        {
                cmdDetalleVentas.CommandType = CommandType.StoredProcedure;
                cmdDetalleVentas.CommandText = "PEDIDO_DET_USP_INSERTAR";
                cmdDetalleVentas.Connection = conn.conectarBD();
            {
                    

                    cmdDetalleVentas.Parameters.AddWithValue("@IdPedidoCab ",item.IdPedidoCab);
                    cmdDetalleVentas.Parameters.AddWithValue("@IdProducto", item.IdProducto);
                    cmdDetalleVentas.Parameters.AddWithValue("@NombreProd", item.NombreProd);
                    cmdDetalleVentas.Parameters.AddWithValue("@IdCupon", item.IdCupon);
                    cmdDetalleVentas.Parameters.AddWithValue("@Cantidad ", item.Cantidad);
                    cmdDetalleVentas.Parameters.AddWithValue("@PrecioUnidad", item.PrecioUnidad);
                    cmdDetalleVentas.Parameters.AddWithValue("@PrecioDescuento", item.PrecioDescuento);
                    cmdDetalleVentas.Parameters.AddWithValue("@Total", item.Total);
        
                   

                }
            int registros;
            registros = cmdDetalleVentas.ExecuteNonQuery();
            if (registros == 1)
            {
                rpta = "OK";
            }
            else
            {
                rpta = "Error al Insertar";
            }
        }
        catch (Exception ex)
        {
            System.Console.Write(ex.Message);
        }
        return rpta;
    }

}
    }
