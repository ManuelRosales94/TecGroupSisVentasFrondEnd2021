using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TecGroupSisVentasFrondEnd2021.Modelos;

namespace TecGroupSisVentasFrondEnd2021.Logic
{
    public class PedidoCabeceraL
 
    {
        public static int id = 0;
        private BDConexion conn = new BDConexion();
        private SqlCommand cmdVentas = new SqlCommand();


        public int Insertar(PedidoCabecera entidad)
        {
            
            try
            {
                
                cmdVentas.CommandType = CommandType.StoredProcedure;
                cmdVentas.CommandText = "PEDIDO_CAB_USP_INSERTAR";
                cmdVentas.Connection = conn.conectarBD();
                {


                    cmdVentas.Parameters.AddWithValue("@IdUsuario", entidad.IdUsuario);
                    cmdVentas.Parameters.AddWithValue("@NombreCli", entidad.NombreCli);
                    cmdVentas.Parameters.AddWithValue("@IdCupon", entidad.IdCupon);
                    cmdVentas.Parameters.AddWithValue("@SubTotal", entidad.SubTotal);
                    cmdVentas.Parameters.AddWithValue("@IGV", entidad.IGV);
                    cmdVentas.Parameters.AddWithValue("@SubTotal2", entidad.SubTotal2);
                    cmdVentas.Parameters.AddWithValue("@Descuentos", entidad.Descuentos);
                    cmdVentas.Parameters.AddWithValue("@Total", entidad.Total);
                    cmdVentas.Parameters.AddWithValue("@MonEnvio", entidad.MonEnvio);
                    cmdVentas.Parameters.AddWithValue("@TotalmasEnvio", entidad.TotalmasEnvio);
                    cmdVentas.Parameters.AddWithValue("@TipoPago", entidad.TipoPago);
                    cmdVentas.Parameters.AddWithValue("@TipoPedido", entidad.TipoPedido);
                    cmdVentas.Parameters.AddWithValue("@EstadoPedido", entidad.EstadoPedido);
                    
                }
             
                 id = Convert.ToInt32(cmdVentas.ExecuteScalar());

              
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return id;


        }
   

        public static int ID()
        {
            return id;
        }
        }
    }

