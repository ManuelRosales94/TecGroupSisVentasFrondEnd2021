using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Models;
using RestSharp;
using TecGroupSisVentasFrondEnd2021.ServicioUsuario;

namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Registrar_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario c = new Usuario();
            c.Nombre = txtNombre.Text;
            c.Apellidos = txtApellidos.Text;
            c.Celular = txtCelular.Text;
            c.idDistrito = 5;
            c.NomDistrito = txtDistrito.Text;
            c.Direccion = txtDireccion.Text;
            c.Correo = txtCorreo.Text;
            c.Contraseña = txtcontraseña.Text;
            c.DNI = txtDNI.Text;
            c.TipoUsuario = "Cliente";

            //http://localhost:55159/UsuarioRestServicio.svc
            var cliente = new RestClient("http://localhost:55159");
            var request = new RestRequest("/UsuarioRestServicio.svc/Rest/Usuario", Method.POST);
            request.AddJsonBody(c);
            var response = cliente.Execute(request);

            try
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    msg.Visible = true;
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtCelular.Text = "";
                    txtDistrito.Text = "";
                    txtDireccion.Text = "";
                    txtCorreo.Text = "";
                    txtcontraseña.Text = "";
                    txtDNI.Text = "";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}