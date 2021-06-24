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
    public partial class AgregarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {       
          //http://localhost:55159/ProductoRestServicio.svc
          var client = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.GET);

            var response = client.Execute(request);
            var lista = SimpleJson.DeserializeObject<IEnumerable<Producto>>(response.Content);


            ddlProductos.DataSource = lista;
            ddlProductos.DataValueField = "IdProducto";
            ddlProductos.DataTextField = "NombreProducto";

            ddlProductos.DataBind();

        }
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();


            p.NombreProducto = txtNombre.Text;
            p.DescProducto = txtDescProducto.InnerText;
            p.Comentarios = "";
            p.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            p.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            p.Foto = txtFoto.Text;
            p.Destacado = 1;
            p.UnidadMedida = "UNIDAD";
            p.IdCategoria = 1;
            p.Categoria = "Computo";
            p.Stock = Convert.ToInt32(txtStock.Text);




            //http://localhost:55159/ProductoRestServicio.svc
            var producto = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.POST);
            request.AddJsonBody(p);

            var response = producto.Execute(request);


            try
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    msg.Visible = true; 
                    txtNombre.Text = "";
                    txtDescProducto.InnerText = "";
                    txtPrecioCompra.Text = "";
                    txtPrecioVenta.Text = "";
                    txtFoto.Text = "";
                    txtStock.Text = "";

                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void ddlProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            msg.Visible = false;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;

            var indice = ddlProductos.SelectedItem.Value;
          

            //http://localhost:55159/ProductoRestServicio.svc
            var client = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto/"+indice, Method.GET);

            var response = client.Execute(request);
            var lista = SimpleJson.DeserializeObject<Producto>(response.Content);

            txtNombre.Text = lista.NombreProducto;
            txtDescProducto.InnerText = lista.DescProducto;
            txtPrecioCompra.Text = Convert.ToString(lista.PrecioCompra);
            txtPrecioVenta.Text = Convert.ToString(lista.PrecioVenta);
            txtFoto.Text = lista.Foto;
            txtStock.Text = Convert.ToString(lista.Stock);
            referId.Text = Convert.ToString(lista.IdCategoria);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
       
            //http://localhost:55159/ProductoRestServicio.svc
            var producto = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ProductoRestServicio.svc/Rest/Producto", Method.PUT);

            Producto p = new Producto();

            p.IdProducto= Convert.ToInt32(ddlProductos.SelectedItem.Value);
            p.NombreProducto = txtNombre.Text;
            p.DescProducto = txtDescProducto.InnerText;
            p.Comentarios = "";
            p.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            p.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            p.Foto = txtFoto.Text;
            p.Destacado = 1;
            p.UnidadMedida = "UNIDAD";
            p.Categoria = "Computo";
            p.Stock = Convert.ToInt32(txtStock.Text);
            p.IdCategoria = Convert.ToInt32(referId.Text);
            p.EstadoProducto = 1;

           request.AddJsonBody(p);
           var response = producto.Execute(request);

            try
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    msg.Visible = true;
                    txtNombre.Text = "";
                    txtDescProducto.InnerText = "";
                    txtPrecioCompra.Text = "";
                    txtPrecioVenta.Text = "";
                    txtFoto.Text = "";
                    txtStock.Text = "";

                    txtNombre.Focus();
                    btnModificar.Visible = false; 
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
    }
    