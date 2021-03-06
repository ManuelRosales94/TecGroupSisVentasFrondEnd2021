using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Modelos;


namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class DetalleProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = (Usuario)Session["user"];
            if (user == null)
            {
                Response.Redirect("/Formularios/IniciarSesion.aspx?IdError=1");
            }

        //    Producto p = new Producto();

        //    //http://localhost:55159/ProductoRestServicio.svc
        //    var producto = new RestClient("http://localhost:55159");
        //    var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

        //    var response = producto.Execute(request);
        //    var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);


        //    dtProductosDetalle.DataSource = lista;
        //    dtProductosDetalle.DataBind();
        //
        }

        
        public IEnumerable<Producto> productDetail_GetItem(
                            [QueryString("IdProducto")] int? idProducto)

        {


            //http://localhost:55159/ProductoRestServicio.svc
            var producto = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            var response = producto.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);

            lista = lista.Where(p => p.IdProducto == idProducto);
            return lista;
        }
    }
}