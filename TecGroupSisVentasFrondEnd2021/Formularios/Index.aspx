<%@ Page Title="" Language="C#"
    MasterPageFile="~/Formularios/PaginaMaestra.Master"
    AutoEventWireup="true" CodeBehind="Index.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container col-md-11">

        <div class="row" id="row">
            <div class="col-md-12 p-2">
                <br />

                <div id="bannerProducto" class="responsive-banner">
                    <img src="../../dist/Imagenes/banner2.jpg" alt="">
                </div>
                <br />

                <asp:DataList ID="dtProductos1" runat="server" DataKeyField="IdProducto" RepeatColumns="4" CssClass="table table-responsive">

                    <ItemTemplate>
             
                
                        <br />
                        <asp:Image  href="/Formularios/DetalleProductos.aspx" ID="Image2" Width="200" Height="240" runat="server" ImageUrl='<%# "../../dist/Imagenes/"+Eval("Foto") %>' CssClass="img-fluid" />
                        <br />
                         <a href="DetalleProductos.aspx?IdProducto="<%# Eval("IdProducto") %>" >Detalle </a>
                         <br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("NombreProducto") %>'></asp:Label>
                        <br />
                        Detalle:
                        <asp:Label ID="Label4" runat="server"  href='DetalleProductos.aspx?IdProducto="<%# Eval("IdProducto") %>'>Editar</asp:Label>
                     <br />

                       

                        Disponible:
                  <asp:Label ID="Label3" runat="server" Text='<%# Eval("Stock") %>'></asp:Label>
                        <br />
                        S/
                  <asp:Label ID="Label2" runat="server" Text='<%# Eval("PrecioVenta") %>'></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="Agregar al Carrito" CssClass="btn btn-success" />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </div>
</asp:Content>



