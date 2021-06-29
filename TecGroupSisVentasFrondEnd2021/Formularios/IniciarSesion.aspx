<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.IniciarSesion" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>AdminLTE 3 | Log in (v2)</title>


  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
  <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css">

  <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
</head>

<body class="hold-transition login-page">
<div class="login-box">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a  class="h1"><b>Tec</b>Group</a>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Regístrese para iniciar su sesión</p>

      <form runat="server">
        <div class="input-group mb-3">


            <asp:TextBox ID="txtUsuario" runat="server" type="text" class="form-control" placeholder="Correo"></asp:TextBox>

          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">

            <asp:TextBox ID="txtPass" runat="server" type="password" class="form-control" placeholder="Contraseña"></asp:TextBox>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-8">
          
          </div>
          <!-- /.col -->
          
            
            <div class="col-5">

              <asp:Button ID="Button1" runat="server" Text="Iniciar" type="submit" class="btn btn-primary btn-block"  OnClick="Button1_Click" />
             
           
                   <div>
              <asp:Label ID="Label1" runat="server" Text=""  ForeColor="Red" Font-Bold="true"></asp:Label>

         
           
</div>
          </div>
          <!-- /.col -->
        </div>
      </form>
 
      <p class="mb-0">
        <a href="/Formularios/RegistrarUsuario.aspx" class="text-center">Registrar Usuario</a>
      </p>
    </div>

  </div>

</div>


</body>
</html>
