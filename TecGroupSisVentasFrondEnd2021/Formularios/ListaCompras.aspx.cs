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
    public partial class ListaCompras : System.Web.UI.Page
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
            var user = (Usuario)Session["user"];
            //http://localhost:55159/ProductoRestServicio.svc
            var client = new RestClient("http://localhost:55159");
            var request = new RestRequest("/PedidoRestServicio.svc/Rest/Pedido", Method.GET);
      
            var response = client.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<PedidoCabecera>>(response.Content);


            //rptCompras.DataSource = lista.Where(p => p.IdUsuario == user.IdUsuario);
            rptCompras.DataSource = lista;

            rptCompras.DataBind();


           


            compra.DataSource = lista;
            compra.DataTextField = "NombreCli";
            compra.DataValueField = "IdUsuario";
            compra.DataBind();
        }


        protected void compra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void rptCompras_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}