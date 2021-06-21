<%@ Page Title="" Language="C#" 
    EnableEventValidation="false" 
    MasterPageFile="~/Formularios/PaginaMaestra.Master"
    AutoEventWireup="true"
    CodeBehind="MantenimientoProducto.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.MantenimientoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <h1>Productos</h1>

    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/Formularios/MantenimientoProducto.aspx">Listar</a></li>
            <li class="breadcrumb-item"><a href="/Formularios/AgregarProductos.aspx">Agregar</a></li>
        
        </ol>
    </nav>
    <br />
    <asp:ListBox ID="Categ" runat="server" SelectionMode="Multiple" AutoPostBack="true" OnSelectedIndexChanged="Categ_SelectedIndexChanged" Visible="false"  ></asp:ListBox>
    <br />
    <asp:Repeater ID="rptProductos" runat="server" OnItemCommand="rptProductos_ItemCommand">
        <HeaderTemplate>
            <table class="table  table-striped table-hover">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>s/ Precio</th>
                        <th>Stock</th>
                        <th>Categoria</th>
                        <th>Editar</th>
                        <th>Eliminar</th>

                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
 
                 <asp:HiddenField ID="hddID" runat="server"  Value='<%# Eval("IdProducto") %>'/>

                <td><%#Eval("NombreProducto") %> </td>
                <td><%#Eval("PrecioVenta") %></td>
                <td><%#Eval("Stock") %> </td>
                <td><%#Eval("Categoria") %></td>

                <td><a href="AgregarProductos.aspx?IdProducto= <%# Eval("IdProducto") %>">Editar</a></td>
                <td> <asp:Button ID="Button1" runat="server" Text="X" CommandName="eliminar" class="btn btn-danger" /></td>

                <%--<%--<td>Eliminar <%# Eval("IdProducto") %>  </td>--%>
                <%--<td><input type="button"id="btnEditar" class="btn btn-dark" value="Editar" /></td>
                <td><input type="button" class="btn btn-danger" value="Eliminar"  /></td>--%>
          
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>

    </asp:Repeater>
</asp:Content>
