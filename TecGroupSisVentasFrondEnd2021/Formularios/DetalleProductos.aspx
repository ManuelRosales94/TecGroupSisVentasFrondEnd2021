<%@ Page Title="" 
    Language="C#" 
    MasterPageFile="~/Formularios/PaginaMaestra.Master" 
    AutoEventWireup="true"
    CodeBehind="DetalleProductos.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.DetalleProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:FormView ID="productDetail" runat="server"
        ItemType="TecGroupSisVentasFrondEnd2021.Modelos.Producto" SelectMethod="productDetail_GetItem" RenderOuterTable="false">

        <ItemTemplate>
             
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/Thumbs/<%#:Item.Foto %>" 
                           style="Width:500px; height:600px"  alt="<%#:Item.NombreProducto %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <h3 class="my-3">
                        <b>Description:</b><br /><%#:Item.NombreProducto %>
                             </h3>
                    

                        <b>Características destacadas:</b><br /><%#:Item.DescProducto %>
                        <br />
                        <h3 class="my-3">
                        <b>Stock:</b><br /><%#:Item.Stock %>
                             </h3>
                         <h3 class="my-3">
                        <span><b>Precio:</b><br />&nbsp;<%#: String.Format("{0:c}", Item.PrecioVenta) %></span>
                              </h3>
                   

                        <b>Mas Información:</b><br />
                        <asp:Label ID="Label7" runat="server" Text='-Precio incluye el IGV'></asp:Label>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text='- Precio sujeto a cambios sin previo aviso.'></asp:Label>
                        <br />
                        <asp:Label ID="Label8" runat="server" Text='-Precio no incluye flete por envío, consultar precios de delivery por Distrito'></asp:Label>
                        <br />
                        </div>
                         <br />
                         <div class="btn btn-primary btn-lg btn-flat">
                            <i class="fas fa-cart-plus fa-lg mr-2"></i>Agregar al Carrito   
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" />
                        </div>
                    </td>

                   
                </tr>
            </table>
            <div class="row mt-4">
                <nav class="w-100">
                    <div class="nav nav-tabs" id="product-tab" role="tablist">
                        <a class="nav-item nav-link active" id="product-desc-tab" data-toggle="tab" href="#product-desc" role="tab" aria-controls="product-desc" aria-selected="true">Comentarios</a>
                    </div>
                </nav>
                <div class="tab-content p-3" id="nav-tabContent">

                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Comentarios") %>'></asp:Label>

                </div>
        </ItemTemplate>


    </asp:FormView>









    <asp:DataList ID="dtProductosDetalle" runat="server" CssClass="table table-responsive">
        <ItemTemplate>


            <table>
                <tr>
                    <td>
                        <asp:Image ID="Image1" Width="500" Height="600" runat="server" ImageUrl='<%# "../../dist/Imagenes/"+Eval("Foto") %>' CssClass="img-fluid" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <br />
                        <h3 class="my-3">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("NombreProducto") %>'></asp:Label>
                        </h3>
          
                        <b>Características destacadas:</b><br />
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("DescProducto") %>'></asp:Label>
                        <br />
                        <br />
                         <h3 class="my-3">
                        <b>Stock:</b><br />
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Stock") %>'></asp:Label>
                             </h3>
                  



                        <div class="bg-gray py-2 px-3 mt-4">
                            <h2></h2>
                            
                            <h2 class="mb-0"><b>S/</b>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("PrecioVenta") %>'></asp:Label>
                            </h2>
                            <br />
                        </div>



                        <br />

                        <b>Mas Información:</b><br />
                        <asp:Label ID="Label7" runat="server" Text='-Precio incluye el IGV'></asp:Label>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text='- Precio sujeto a cambios sin previo aviso.'></asp:Label>
                        <br />
                        <asp:Label ID="Label8" runat="server" Text='-Precio no incluye flete por envío, consultar precios de delivery por Distrito'></asp:Label>
                        <br />
                        </div>
                         <br />

                        <div class="btn btn-primary btn-lg btn-flat">
                            <i class="fas fa-cart-plus fa-lg mr-2"></i>Agregar al Carrito   
                        <asp:Button ID="Button1" runat="server" class="btn btn-primary" />
                        </div>



                    </td>
                </tr>
            </table>
            <br />
            <br />
            <div class="row mt-4">
                <nav class="w-100">
                    <div class="nav nav-tabs" id="product-tab" role="tablist">
                        <a class="nav-item nav-link active" id="product-desc-tab" data-toggle="tab" href="#product-desc" role="tab" aria-controls="product-desc" aria-selected="true">Comentarios</a>
                    </div>
                </nav>
                <div class="tab-content p-3" id="nav-tabContent">

                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Comentarios") %>'></asp:Label>

                </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
