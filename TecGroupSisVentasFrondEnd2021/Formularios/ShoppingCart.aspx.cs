using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Logic;
using TecGroupSisVentasFrondEnd2021.Modelos;

namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        private dbVentas _db = new dbVentas();
        protected void Page_Load(object sender, EventArgs e)
        {




            var user = (Usuario)Session["user"];
            if (user == null)
            {
                Response.Redirect("/Formularios/IniciarSesion.aspx?IdError=1");
            }

            txtCliente.Text = user.Nombre + " " + user.Apellidos;

            montos();
        }
        public void montos()
        {

            Label1.Text = DateTime.Now.ToLongDateString();

            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {

                decimal cartTotal = 0;
                double cartTotal2 = 0;
                double igv = 0;
                double subtotal = 0;
                cartTotal = usersShoppingCart.GetTotal();
                if (cartTotal > 0)
                {
                    // Display Total.
                    cartTotal2 = Convert.ToDouble(cartTotal);
                    lblTotal.Text = cartTotal2.ToString("0.00");
                    igv = cartTotal2 * 0.18;
                    // Subtotal.Text = String.Format("{ 0:c}", subtotal);
                    subtotal = cartTotal2 - igv;
                    IGV.Text = igv.ToString("0.00");
                    Subtotal.Text = subtotal.ToString("0.00");
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    ShoppingCartTitle.InnerText = "Shopping Cart is Empty";
                    UpdateBtn.Visible = false;
                    // CheckoutImageBtn.Visible = false;
                }
            }

        }


        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }
        public List<CartItem> UpdateCartItems()
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                String cartId = usersShoppingCart.GetCartId();

                ShoppingCartActions.ShoppingCartUpdates[] cartUpdates = new ShoppingCartActions.ShoppingCartUpdates[CartList.Rows.Count];
                for (int i = 0; i < CartList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(CartList.Rows[i]);
                    cartUpdates[i].ProductId = Convert.ToInt32(rowValues["ProductID"]);

                    CheckBox cbRemove = new CheckBox();
                    cbRemove = (CheckBox)CartList.Rows[i].FindControl("Remove");
                    cartUpdates[i].RemoveItem = cbRemove.Checked;

                    TextBox quantityTextBox = new TextBox();
                    quantityTextBox = (TextBox)CartList.Rows[i].FindControl("PurchaseQuantity");
                    cartUpdates[i].PurchaseQuantity = Convert.ToInt16(quantityTextBox.Text.ToString());
                }
                usersShoppingCart.UpdateShoppingCartDatabase(cartId, cartUpdates);
                CartList.DataBind();
                lblTotal.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());
                return usersShoppingCart.GetCartItems();
            }
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    // Extract values from the cell.
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            
            UpdateCartItems();
            montos();
        }

        protected void btnPedido_Click(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                decimal cartTotal = 0;
                cartTotal = usersShoppingCart.GetTotal();


                var user = (Usuario)Session["user"];
                txtCliente.Text = user.Nombre + " " + user.Apellidos;


                int registroGenerado = 0;
                Logic.PedidoCabeceraL oVentasCab = new Logic.PedidoCabeceraL();
                Modelos.PedidoCabecera oVentasModelo = new Modelos.PedidoCabecera();




                oVentasModelo.IdUsuario = user.IdUsuario;
                oVentasModelo.NombreCli = user.Nombre;
                oVentasModelo.IdCupon = 1;
                oVentasModelo.SubTotal2 = 0;
                oVentasModelo.Descuentos = 0;
                oVentasModelo.Total = cartTotal;
                oVentasModelo.SubTotal = Convert.ToDecimal(Subtotal.Text);
                oVentasModelo.IGV = Convert.ToDecimal(IGV.Text);
                oVentasModelo.MonEnvio = 0;
                oVentasModelo.TotalmasEnvio = 0;
                oVentasModelo.TipoPago = "Pendiente";
                oVentasModelo.TipoPedido = "Recojo Tienda";
                oVentasModelo.EstadoPedido = "Pendiente";

                oVentasCab.Insertar(oVentasModelo);

                registroGenerado = PedidoCabeceraL.ID();



                var cartItems = _db.ShoppingCartItems;

                foreach (var item in cartItems)
                {
                    Logic.PedidoDetalleL oVentasDet = new Logic.PedidoDetalleL();
                    Modelos.PedidoDetalle oVentasModeloDet = new Modelos.PedidoDetalle();


                    oVentasModeloDet.IdPedidoCab = registroGenerado;
                    oVentasModeloDet.IdProducto = item.ProductId;
                    oVentasModeloDet.NombreProd = item.Producto.NombreProducto;
                    oVentasModeloDet.IdCupon = 0;
                    oVentasModeloDet.Cantidad = item.Quantity;
                    oVentasModeloDet.PrecioUnidad = item.Producto.PrecioVenta;
                    oVentasModeloDet.PrecioDescuento = 0;
                    oVentasModeloDet.Total = item.Producto.PrecioVenta * item.Quantity;
                    oVentasModeloDet.CartId = item.CartId;
                    oVentasDet.Insertar(oVentasModeloDet);

                   
                }
                Response.Redirect("/Formularios/ListaCompras.aspx");
            }
        }

    }
}

//var user = (Usuario)Session["user"];

//txtCliente.Text = user.Nombre + " " + user.Apellidos;

//PedidoCabecera p = new PedidoCabecera();

//p.IdUsuario = 1;
//p.NombreCli = user.Nombre;
//p.IdCupon = 1;
//p.SubTotal = 1;
//p.IGV = 1;
//p.SubTotal2 = 1;
//p.Descuentos = 1;
//p.Total = 23;
//p.MonEnvio = 1;
//p.TotalmasEnvio = 1;
//p.TipoPago = "dd";
//p.TipoPedido = "dd";
//p.EstadoPedido = "dd",
//    detalle:[





//var cartItems = _db.ShoppingCartItems;
////foreach (var item in p.detalle)
// foreach (var item in cartItems)

//{
//    CartItems detalle2 = new CartItems();
//    detalle2.ProductId = 6;
//    //detalle2.IdProducto = 3;
//    //detalle2.NombreProd = "";
//    //detalle2.IdCupon = 1;
//    //detalle2.Cantidad = 1;
//    //detalle2.PrecioUnidad = 1;
//    //detalle2.PrecioDescuento = 1;
//    //detalle2.Total = 1;

//    //}

//    PedidoDetalle detalle = new PedidoDetalle>();

//    PedidoCabecera p = new PedidoCabecera()
//    {
//        IdUsuario = 1,
//        NombreCli = "yerson",
//        detalle.Cantidad=2,


//};





////http://localhost:55159/ProductoRestServicio.svc
//var producto = new RestClient("http://localhost:55159");
//var request = new RestRequest("/PedidoRestServicio.svc/Rest/Pedido", Method.POST);
//request.AddJsonBody(p);


//var response = producto.Execute(request);
