<%@ Page Title="" Language="C#"
    EnableEventValidation="false"
    MasterPageFile="~/Formularios/PaginaMaestra.Master"
    AutoEventWireup="true" CodeBehind="Index.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
    <div class="container col-md-11">
                  <asp:Label ID="Label4" runat="server" Text="Bienvenido: "></asp:Label>
                 <asp:Label ID="txtUsuario" runat="server" Text=" "></asp:Label>
            </div> 
         

     

        <div class="row" id="row">
        <div class="row" id="row">
            <div class="col-md-12 p-2">
                <br />
                
                <div id="bannerProducto" class="responsive-banner">
                    <img src="../../dist/Imagenes/banner2.jpg" alt
                         <img src="../../dist/Imagenes/banner2.jpg" alt="">
                </div>

                <br />
                 <tr>
                        <td>
                            <h3>Lista de Productos</h3>                                                       
                          
                        </td>
                       
                    </tr> 






      <asp:ListView ID="productList" runat="server"
                    DataKeyNames="IdProducto" GroupItemCount="4"
                    ItemType="TecGroupSisVentasFrondEnd2021.Modelos.Producto" 
                    SelectMethod="productList_GetData" OnItemCommand="productList_ItemCommand"   >
<EmptyDataTemplate>
    <table>
        <tr>
             <td>No hay  Productos .</td>
        </tr>
    </table>
</EmptyDataTemplate>
          <EmptyItemTemplate>
              <td />
          </EmptyItemTemplate>
         <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
         </GroupTemplate>
          <ItemTemplate>
                  <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="DetalleProductos.aspx?IdProducto=<%#:Item.IdProducto%>">
                                        <img src="/Catalog/Images/Thumbs/<%#:Item.Foto%>" Width="200" Height="240"
                                            CssClass="img-fluid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="DetalleProductos.aspx?IdProducto=<%#:Item.IdProducto%>">
                                        <span><%#:Item.NombreProducto%> 
                                        </span>
                                    </a>

                                   <br />
                                        <b>Stock: </b<span><%#:Item.Stock%> 
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Precio: </b><%#:String.Format("{0:c}", Item.PrecioVenta)%> 
                                        </span>
                                    <br />
                                    <a  href="AddToCart.aspx?IdProducto=<%#: Item.IdProducto %>" CommandName="add"  >
                                        <span class="ProductListItem" >
                                            <b>Agregar Carrito</b>
                                           
                                        </span>
                                    </a>

                                     
                                  
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
          </ItemTemplate>
          <LayoutTemplate>
              <table style="width: 100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
          </LayoutTemplate>

                </asp:ListView>



















<%--             <asp:DataList ID="dtProductos1" runat="server"  AutoPostBack="true"
                     DataKeyField ="IdProducto" RepeatColumns="4" CssClass="table table-responsive" 
                    OnItemCommand="dtProductos1_ItemCommand"   >

                    <ItemTemplate>
                     
                        <br />
                        <asp:Image  href="/Formularios/DetalleProductos.aspx" ID="Image2" Width="200" Height="240"
                            runat="server" ImageUrl='<%# "../../dist/Imagenes/"+Eval("Foto") %>'
                            CssClass="img-fluid" />
                        <br />

                        <asp:HiddenField ID="hddID" runat="server"  Value='<%# Eval("IdProducto") %>'/>


                         <a href="DetalleProductos.aspx?IdProducto="<%# Eval("IdProducto") %>" >Ver más </a>
                         <br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("NombreProducto") %>'></asp:Label>
                        <%--<br />
                        Detalle:
                        <asp:Label ID="Label4" runat="server"  href='DetalleProductos.aspx?IdProducto="<%# Eval("IdProducto") %>'>Editar</asp:Label>
                     <br />

                      
                        Disponible:
                  <asp:Label ID="Label3" runat="server" Text='<%# Eval("Stock") %>'></asp:Label>
                        <br />
                        S/
                  <asp:Label ID="Label2" runat="server" Text='<%#Eval("PrecioVenta") %>'></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="txtAgregar" runat="server" CommandName="add" Text ="Agregar al Carrito" CssClass="btn btn-success" />
                        <br />
                        <%--<a href="CarritoCompra.aspx?IdProducto="<%# Eval("IdProducto") %>">
                                        <span class ="ProductListItem">
                                            <b>Add to Cart</b>
                                        </span>
                                    </a>
                        
                    </ItemTemplate>
                </asp:DataList>--%>

<%--            </div>
        </div>
    </div>--%>
</asp:Content>



