using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.ServicioUsuario;

namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginUsers_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var user = LoginUsers.UserName;
            var pass = LoginUsers.Password;
            Usuario usuario = new Usuario {DNI=user ,Contraseña=pass};

            //http://localhost:55159/UsuarioRestServicio.svc
            var client = new RestClient("http://localhost:55159");
            var request = new RestRequest("/UsuarioRestServicio.svc/Rest/ValidarUsuario", Method.POST);
            request.AddJsonBody(usuario);
            var response = client.Execute(request);
            Usuario resultadoLogin;

            resultadoLogin = SimpleJson.DeserializeObject<Usuario>(response.Content);

            if (resultadoLogin.IdUsuario != -1)
            {
                FormsAuthentication.RedirectFromLoginPage(user, LoginUsers.RememberMeSet);
            }
            else
            {
                LoginUsers.FailureText = "Usuario o Contraseña Incorrecto";
            }
        }
   
    }
}