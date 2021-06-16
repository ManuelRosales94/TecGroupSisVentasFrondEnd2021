using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecGroupSisVentasFrondEnd2021.Models;
using RestSharp;

namespace TecGroupSisVentasFrondEnd2021.Formularios
{
    public partial class Registrar_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            //string Nombre = txtNombre.Text;
            //string Apellidos = txtApellidos.Text;
            //string Celular = txtCelular.Text;

            //string NomDistrito = txtDistrito.Text;
            //string Direccion = txtDireccion.Text;
            //string Correo = txtCorreo.Text;
            //string Contraseña = txtcontraseña.Text;
            //string DNI = txtDNI.Text;
            c.Nombre = txtNombre.Text;
            c.Apellidos = txtApellidos.Text;
            c.Celular = txtCelular.Text;
            c.idDistrito = 5;
            c.NomDistrito = txtDistrito.Text;
            c.Direccion = txtDireccion.Text;
            c.Correo = txtCorreo.Text;
            c.Contraseña = txtcontraseña.Text;
            c.DNI = txtDNI.Text;



            //c.Nombre = Nombre;
            //c.Apellidos = Apellidos;
            //c.Celular = Celular;
            //c.idDistrito = 5;
            //c.NomDistrito = NomDistrito;
            //c.Direccion = Direccion;
            //c.Correo = Correo;
            //c.Contraseña = Contraseña;
            //c.DNI =DNI;

            //http://localhost:55159/ClienteRestServicio.svc
            var cliente = new RestClient("http://localhost:55159");
            var request = new RestRequest("/ClienteRestServicio.svc/Rest/Cliente", Method.POST);
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