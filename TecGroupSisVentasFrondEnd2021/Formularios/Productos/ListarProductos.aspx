<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Productos.ListarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <link  href="../dist/css/adminlte.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="dgProductos" runat="server" ></asp:GridView>


        </div>

        <asp:Repeater ID="rpProductos" runat="server">

    <HeaderTemplate>

<table>
    <thead>
        <th>IdProducto</th>
        <th>NombreProducto</th>
        <th>Editar</th>
        <th>Eliminar</th>
    </thead>
<tbody>

    </HeaderTemplate>

    <ItemTemplate>
          <tr>
              <td><%# Eval("IdProducto") %></td
                  <td><%# Eval("NombreProducto")%></td
              <td><a href="Formulario2.aspx?IdProducto=<%#Eval("IdProducto")%>">Editar</a></td>        
              <td>Eliminar <%#Eval("IdProducto")%> </td>
         </tr>
    </ItemTemplate>

    <FooterTemplate>
  </tbody>
    </table>
 
    </FooterTemplate>


</asp:Repeater>

    </form>
</body>
</html>
