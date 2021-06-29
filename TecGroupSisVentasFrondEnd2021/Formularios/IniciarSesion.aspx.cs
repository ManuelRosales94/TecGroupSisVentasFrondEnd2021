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
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["carrito"] = new CarritoCompras();
            var idError=  Convert.ToInt32( Request.QueryString["IdError"]);
            if (idError != 0 )
            {
                switch (idError)
                {
                    case 1:
                        Label1.Text = "Intentaste Ingresar Pagina Protegida";
                        break;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var user = txtUsuario.Text;
            var pass = txtPass.Text;
            Usuario usuario = new Usuario { DNI = user, Contraseña = pass };

            //http://localhost:55159/UsuarioRestServicio.svc
            var client = new RestClient("http://localhost:55159");
            var request = new RestRequest("/UsuarioRestServicio.svc/Rest/ValidarUsuario", Method.POST);
            request.AddJsonBody(usuario);
            var response = client.Execute(request);
            Usuario resultadoLogin;

            resultadoLogin = SimpleJson.DeserializeObject<Usuario>(response.Content);

      
            if (resultadoLogin.IdUsuario != -1)
            {
                Session["user"] = resultadoLogin;
                CarritoCompras carrito = (CarritoCompras)Session["carrito"];
                carrito.Usuario = resultadoLogin;
                Session["carrito"] = carrito;
                Response.Redirect("/Formularios/Index.aspx");
              
            }
            else
            {
                Session["user"] = null;
                Label1.Text= "Usuario o Contraseña Incorrecto";
                txtUsuario.Text = "";
                txtPass.Text = "";
            }
        }

    }
}