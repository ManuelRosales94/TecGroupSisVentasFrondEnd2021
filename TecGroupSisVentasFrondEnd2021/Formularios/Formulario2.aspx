<%@ Page Title="" Language="C#" 
    MasterPageFile="~/Formularios/PaginaMaestra.Master"
    AutoEventWireup="true" CodeBehind="Formulario2.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Formulario_web2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<asp:Repeater ID="rpProductos" runat="server">

    <HeaderTemplate>

<table>
    <thead>
        <th>IdProducto</th>
        <th>NombreProducto</th>
         <th>DesProducto</th>
        <th>Editar</th>
        <th>Eliminar</th>
    </thead>
<tbody>

    </HeaderTemplate>

    <ItemTemplate>
          <tr>
               <td><%# Eval("IdProducto") %></td
               <td><%# Eval("IdProducto") %></td
              <td><%# Eval("NombreProducto")%></td
              <td><a href="Formulario2.aspx?IdProducto=<%#Eval("IdProducto")%>"> Editar </a></td>        
              <td>Eliminar <%#Eval("IdProducto")%> </td
             
         </tr>
    </ItemTemplate>

    <FooterTemplate>
  </tbody>
    </table>
 
    </FooterTemplate>


</asp:Repeater>

   
</asp:Content>


