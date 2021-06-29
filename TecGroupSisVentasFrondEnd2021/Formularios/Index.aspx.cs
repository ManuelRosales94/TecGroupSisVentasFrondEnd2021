using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Modelos;


namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Index : System.Web.UI.Page
    {
     
     
        protected void Page_Load(object sender, EventArgs e)
        {

            var user = (Usuario)Session["user"];
            if (user == null)
            {
                Response.Redirect("/Formularios/IniciarSesion.aspx?IdError=1");
            }

            txtUsuario.Text = user.Nombre + " " + user.Apellidos;

            //Producto p = new Producto();

            ////http://localhost:55159/ProductoRestServicio.svc
            //var producto = new RestClient("http://localhost:55159");
            //var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            //var response = producto.Execute(request);
            //var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);



            //dtProductos1.DataSource = lista;
            //dtProductos1.DataBind();

            //if (Page.IsPostBack == false)
            //{


            //}
        }



        protected void dtProductos1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //string cod;
            //string des = null, nom = null;
            //double precio = 0;
            //if (e.CommandName == "add")
            //{
            //    dtProductos1.SelectedIndex = e.Item.ItemIndex;

            //    cod = ((Label)this.dtProductos1.SelectedItem.FindControl("codproductoLabel")).Text;
            //    des = ((Label)this.dtProductos1.SelectedItem.FindControl("desproductoLabel")).Text;
            //    precio = double.Parse(((Label)this.dtProductos1.SelectedItem.FindControl("preproductoLabel")).Text);
            //    //AgregarItem(cod, des, precio);

            //    lblAgregado.Text = "Producto Agregado: " + nom + " " + des;
            //    //Session["prueba"] = "Sesión usuario prueba";
            //}


        }

        protected void ImageButton1_Click(object sender, EventArgs e)
        {

        }


        public IEnumerable<Producto> productList_GetData(
                            [QueryString("id")] int? categoryId)

        {
            Producto p = new Producto();

            //http://localhost:55159/ProductoRestServicio.svc
            var producto = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            var response = producto.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);

            return lista;

        }

        protected void productList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}