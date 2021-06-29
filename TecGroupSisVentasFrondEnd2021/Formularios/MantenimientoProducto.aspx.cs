using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Modelos;


namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class MantenimientoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (Usuario)Session["user"];
            if (user == null)
            {
                Response.Redirect("/Formularios/IniciarSesion.aspx?IdError=1");
            }


            if (!IsPostBack)
            {

                refreshProducto();
            }
        }
        public void refreshProducto()
        {
            //http://localhost:55159/ProductoRestServicio.svc
            var client = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            var response = client.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);


            rptProductos.DataSource = lista;
            rptProductos.DataBind();

            Categ.DataSource = lista;
            Categ.DataTextField = "NombreProducto";
            Categ.DataValueField = "IdProducto";
            Categ.DataBind();
        }


        protected void rptProductos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {

                var con = ((HiddenField)(e.Item.Controls[1])).Value;
                var client = new RestClient("http://localhost:55159");
                var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto/" + con, Method.DELETE);

                var response = client.Execute(request);
                refreshProducto();
            }
        }




        protected void Categ_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

