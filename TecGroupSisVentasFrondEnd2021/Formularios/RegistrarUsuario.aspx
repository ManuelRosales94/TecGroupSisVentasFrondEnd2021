
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
         <asp:TextBox ID="txtDNI" runat="server"   type="number" class="form-control" placeholder="DNI" required="" ></asp:TextBox>
             <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
          
          <div class="input-group mb-3">      
         <asp:TextBox ID="txtNombre" runat="server"   type="text" class="form-control" placeholder="Nombre Completo"  required="" ></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

            <div class="input-group mb-3">      
          <asp:TextBox ID="txtApellidos" runat="server" type="text" class="form-control" placeholder="Apellidos" required=""></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

              <div class="input-group mb-3">      
           <asp:TextBox ID="txtCelular" runat="server" type="number" class="form-control" placeholder="Celular" required=""></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

             <div class="input-group mb-3">      
                 <asp:TextBox ID="txtDistrito" runat="server"  type="text" class="form-control" placeholder="Distrito" required=""></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

             <div class="input-group mb-3">      
                 <asp:TextBox ID="txtDireccion" runat="server" type="text" class="form-control" placeholder="Direccion" required=""></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

        <div class="input-group mb-3">
         <asp:TextBox ID="txtCorreo" runat="server" type="email" class="form-control" placeholder="Correo" required=""></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>

        <div class="input-group mb-3">
       <asp:TextBox ID="txtcontraseña" runat="server" type="password" class="form-control" placeholder="Contraseña" required=""></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>


        <div class="row">   
          <div class="col-4">
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" class="btn btn-success"/>
          </div>

        </div>

          <div class="alert alert-success" runat="server" role ="alert" id="msg" visible="false">
              registro correcto

          </div>
      </form>


      <a  href="/Formularios/IniciarSesion.aspx" class="signup">Iniciar Sesion</a>
    </div>
  </div>
</div>

</body>

</html>
