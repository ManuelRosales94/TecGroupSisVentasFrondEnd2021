<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Login" %>

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
        <form id="form1" runat="server">
        
            <div>
            <asp:Login ID="LoginUsers" runat="server" OnAuthenticate="LoginUsers_Authenticate" RememberMeText="Recordar."></asp:Login>          
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
