using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Modelos;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Registrar_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var miDNI = txtDNI.Text;
            var client = new RestClient("https://inleggo.io/");
            var request = new RestRequest(string.Format("ws/?/tmpwsdni/get/{0}", miDNI), Method.GET);
            ////https://inleggo.io/ws/?/tmpwsdni/get/43431568            
            var respuesta = client.Execute(request);
            //  Dim respuesta = client.Execute(Of List(Of AybReservaRestauranteWeb_Area))(request)
            var content = respuesta.Content;
            if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var retorno = JsonConvert.DeserializeObject<UsuarioAPI>(respuesta.Content);
                txtNombre.Text = retorno.nombres;
                txtApellidos.Text = retorno.paterno+ " "+ retorno.materno;
                txtDistrito.Text = retorno.distrito;
                txtDireccion.Text = retorno.direccion;
                txtCorreo.Text = "";
                txtcontraseña.Text = "";
                txtCelular.Text = "";
            }
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