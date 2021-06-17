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
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
                Producto p = new Producto();

            //http://localhost:55159/ProductoRestServicio.svc
            var producto = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            var response = producto.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);


            rpProductos.DataSource = lista;
            rpProductos.DataBind();
        }

       
    }
}