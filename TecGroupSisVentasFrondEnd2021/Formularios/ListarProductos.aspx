<%@ Page Title="" Language="C#" 
    MasterPageFile="~/Formularios/PaginaMaestra.Master"
    AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Formulario_web2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


                                        
<asp:Repeater ID="rpProductos" runat="server"   >

    <HeaderTemplate>
   
    </HeaderTemplate>

    <ItemTemplate>
        <asp:Image ID="Image2" width="140" height="120" runat="server" ImageUrl='<%# "~/Imagenes/"+Eval("Foto") %>' CssClass="img-fluid" />
        <br />
        NombreProducto :       
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("NombreProducto") %>'></asp:Label>
        <br />
        PrecioVenta :
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("PrecioVenta") %>'></asp:Label>
        <br />
        Stock:
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Stock") %>'></asp:Label>
        <br />
        Foto :
        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Foto") %>'></asp:Label>
        <br />
        

    
    </ItemTemplate>

    <FooterTemplate>

    </FooterTemplate>


</asp:Repeater>

   
</asp:Content>


