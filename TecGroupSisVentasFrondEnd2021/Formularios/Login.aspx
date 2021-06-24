<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Login" %>

<!DOCTYPE html>

<html lang="en">

<head runat="server">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Iniciar Sesion TecGroup</title>


  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
  <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css">

  <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
    <style type="text/css">
        .auto-style1 {
            height: 14px;
        }
        .auto-style2 {
            height: 220px;
        }
        .auto-style3 {
            height: 204px;
            width: 326px;
        }
    </style>
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
            <asp:Login ID="LoginUsers" runat="server" OnAuthenticate="LoginUsers_Authenticate" RememberMeText="Recordar." BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Double" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="278px" LoginButtonText="Iniciar Sesion" PasswordLabelText="Contraseña:" TitleText="Login" UserNameLabelText="Usuario" Width="326px">
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <LayoutTemplate>
                    <table cellpadding="4" cellspacing="0" class="auto-style2" style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0" class="auto-style3">
                                    <tr>
                                        <td align="center" colspan="2" style="color:White;background-color:#5D7B9D;font-size:0.9em;font-weight:bold;">Login</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario:         </asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="LoginUsers">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="LoginUsers">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style1" colspan="2"></td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Button ID="LoginButton" runat="server" BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" Height="39px" Text="Iniciar Sesion" ValidationGroup="LoginUsers" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" colspan="2">&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <TextBoxStyle Font-Size="0.8em" />
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                </asp:Login>          
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
