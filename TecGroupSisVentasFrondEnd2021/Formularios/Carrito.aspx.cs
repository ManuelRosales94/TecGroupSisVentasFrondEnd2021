using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Modelos;

namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (Usuario)Session["user"];
            if (user == null)
            {
                Response.Redirect("/Formularios/IniciarSesion.aspx?IdError=1");
            }
            var UserFromCache = Cache["user"];

            CarritoCompras carrito = (CarritoCompras)Session["carrito"];
            txtNombre.Text = carrito.Usuario.Nombre;
            txtCantidad.Text = carrito.productos.Count()+"";
        }
    }
}