
<%@ Page Language="C#" 
    AutoEventWireup="true"
    CodeBehind="RegistrarUsuario.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Registrar_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>Registrar Clientes</title>

    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <link  href="../dist/css/adminlte.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback" />
    <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css" />
   

</head>
<body class="hold-transition register-page">

<div class="register-box">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a  class="h1"><b>Tec</b>Group</a>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Registrar un nuevo usuario</p>


      <form  id="form1" runat="server">

         <div class="input-group mb-3">      
         <asp:TextBox ID="txtDNI" runat="server"   type="number" class="form-control" placeholder="DNI" required="" OnTextChanged="btnBuscar_Click" ></asp:TextBox>
            
             <div class="input-group-append">
              
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

       


          <div class="row">   
          <div class="col-4">
    <asp:Button ID="Button1" runat="server" Text="Buscar Reniec" OnClick="btnBuscar_Click" class="btn btn-success"/>
          
          </div>

        </div>
          <br />

                    <div class="input-group mb-3">      
         <asp:TextBox ID="txtNombre" runat="server"   type="text" class="form-control" placeholder="Nombre Completo"
             requerid=""   ValidationGroup="form_ejm"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

            <div class="input-group mb-3">      
          <asp:TextBox ID="txtApellidos" runat="server" type="text" class="form-control" placeholder="Apellidos" ></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

              <div class="input-group mb-3">      
           <asp:TextBox ID="txtCelular" runat="server" type="number" class="form-control" placeholder="Celular" ></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

             <div class="input-group mb-3">      
                 <asp:TextBox ID="txtDistrito" runat="server"  type="text" class="form-control" placeholder="Distrito" ></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

             <div class="input-group mb-3">      
                 <asp:TextBox ID="txtDireccion" runat="server" type="text" class="form-control" placeholder="Direccion" ></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

        <div class="input-group mb-3">
         <asp:TextBox ID="txtCorreo" runat="server" type="email" class="form-control" placeholder="Correo"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>

        <div class="input-group mb-3">
       <asp:TextBox ID="txtcontraseña" runat="server" type="password" class="form-control" placeholder="Contraseña" ></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>


        <div class="row">   
          <div class="col-4">
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click"
        class="btn btn-success"  ValidationGroup="form_ejm"        />
          </div>

        </div>

          <div class="alert alert-success" runat="server" role ="alert" id="msg" visible="false">
              Registro Correcto

          </div>

      </form>


      <a  href="/Formularios/IniciarSesion.aspx" class="signup">Iniciar Sesión</a>
    </div>
  </div>
</div>

</body>

</html>
