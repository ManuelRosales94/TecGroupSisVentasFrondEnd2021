using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Modelos;


namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Index : System.Web.UI.Page
    {
        DataTable dtb;
        DataTable carrito = new DataTable();

      

        public void CargarDetalle()
        {
            
                dtb = new DataTable("Carrito");
                dtb.Columns.Add("IdProducto", System.Type.GetType("System.String"));
                dtb.Columns.Add("NombreProducto", System.Type.GetType("System.String"));
                dtb.Columns.Add("PrecioVenta", System.Type.GetType("System.Double"));
                dtb.Columns.Add("subtotal", System.Type.GetType("System.Double"));
                dtb.Columns.Add("canproducto", System.Type.GetType("System.Int32"));

              
        }

        public void AgregarItem(string cod, string des, double precio)
        {
            double total;
            int cantidad = 1;
            total = precio * cantidad;
            //carrito = (DataTable)Session["pedido"];
            DataRow fila = carrito.NewRow();
            fila[0] = cod;
            fila[1] = des;
            fila[2] = precio;
            fila[3] = (int)cantidad;
            fila[4] = total;
            carrito.Rows.Add(fila);
            //Session["pedido"] = carrito;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            var userFromCache = Cache["user"];
            


            //if (!Page.User.Identity.IsAuthenticated)
            //{
            //    FormsAuthentication.RedirectToLoginPage();
            //}
            Producto p = new Producto();

            //http://localhost:55159/ProductoRestServicio.svc
            var producto = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            var response = producto.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);

            Session["Catalogo"] = lista;
            CarritoCompra carritoCompra = (CarritoCompra)Session["carrito"];

            dtProductos1.DataSource = lista;
            dtProductos1.DataBind();

            if (Page.IsPostBack == false)
            {
                CargarDetalle();
                Label5.Text = "";
            }
        }

        protected void dtProductos1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            {
                string cod;
                string des = null, nom = null;
                double precio = 0;
                if (e.CommandName == "Seleccionar")
                {
                    dtProductos1.SelectedIndex = e.Item.ItemIndex;

                    cod = ((Label)this.dtProductos1.SelectedItem.FindControl("Label1")).Text;
                    des = ((Label)this.dtProductos1.SelectedItem.FindControl("Label2")).Text;
                    precio = double.Parse(((Label)this.dtProductos1.SelectedItem.FindControl("Label3")).Text);
                    AgregarItem(cod, des, precio);

                  Label5.Text = "Producto Agregado: " + nom + " " + des;
                    //Session["prueba"] = "Sesión usuario prueba";
                }
            }
        }
    }
    }
