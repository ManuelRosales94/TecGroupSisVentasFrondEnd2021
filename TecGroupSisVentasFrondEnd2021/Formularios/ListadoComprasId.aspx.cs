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
    public partial class ListadoComprasId : System.Web.UI.Page
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
            var request = new RestRequest("/PedidoRestServicio.svc/Rest/PedidoTotal", Method.GET);

            var response = client.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<PedidoCabecera>>(response.Content);


            Repeater1.DataSource = lista.Where(p => p.IdUsuario == user.IdUsuario);
            Repeater1.DataBind();





            compraID.DataSource = lista;
            compraID.DataTextField = "NombreCli";
            compraID.DataValueField = "IdUsuario";
            compraID.DataBind();

        }
            protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}