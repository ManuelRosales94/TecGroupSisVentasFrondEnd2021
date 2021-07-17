using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TecGroupSisVentasFrondEnd2021.Logic
{
    public class BDConexion
    {

        //private string cadena = @"Data Source=.;                                                        Initial Catalog=BD_TEC_GROUP_VENTAS;Integrated Security=True";
        //private string cadena = @"Data Source = dbtecgroup.c2jmxny0uixg.us - east - 2.rds.amazonaws.com; Initial Catalog = BD_TEC_GROUP_VENTAS; Integrated Security=True;User ID = admin; Password=dbtecgroup";
        private string cadena = @"Data Source=dbtecgroup.c2jmxny0uixg.us-east-2.rds.amazonaws.com;Initial Catalog=BD_TEC_GROUP_VENTAS;Persist Security Info=True;User ID=admin;Password=dbtecgroup";


        private SqlConnection conexion;

        public SqlConnection conectarBD()
        {
            conexion = new SqlConnection(cadena);
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            else
            {
                conexion.Open();
            }
            return conexion;
        }
    }
}
