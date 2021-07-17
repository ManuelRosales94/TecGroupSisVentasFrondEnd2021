<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ListadoComprasId.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.ListadoComprasId" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Lista de Pedidos"></asp:Label>
    <asp:ListBox ID="compraID" runat="server" selectionMode="Multiple" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Visible="false" ></asp:ListBox>

<br />

    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
        <HeaderTemplate>
            <table class="table  table-striped table-hover">
                <thead>
                    <tr>
                        <th>Id Pedido</th>
                        <th>NombreCliente</th>
                        <th>S/ Total</th>
                        <th>Tipo Pedido</th>
                        <th>Estado Pedido</th>
                      

                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                 <td><%#Eval("IdPedidoCab") %> </td>
                <td><%#Eval("NombreCli") %></td>
                <td><%#Eval("Total") %> </td>
                <td><%#Eval("TipoPedido") %></td>
                <td><%#Eval("EstadoPedido") %></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
             </tbody>
            </table>
        </FooterTemplate>

    </asp:Repeater>
</asp:Content>
