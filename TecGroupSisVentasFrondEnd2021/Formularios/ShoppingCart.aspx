<%@ Page Title="" Language="C#"
    MasterPageFile="~/Formularios/PaginaMaestra.Master" 
    AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs"
    Inherits="TecGroupSisVentasFrondEnd2021.Formularios.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat ="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Lista de Productos:</h1></div>
    
    <tr>
                        <td style="width: 77px">Cliente :</td>
                        <td style="width: 397px; margin-bottom: 4px; margin-top: 4px">
                            <asp:TextBox ID="txtCliente" runat="server" Width="332px" CssClass="form-control"></asp:TextBox>
                           
                        </td>
                        
                    </tr>
    <div>
 <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    

    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="false"
        ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="TecGroupSisVentasFrondEnd2021.Modelos.CartItem" SelectMethod="GetShoppingCartItems" 
   CssClass="table table-striped table-bordered" >          
        <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="ProductID" />       
                <asp:BoundField DataField="Producto.NombreProducto" HeaderText="Producto" />   
                <asp:BoundField DataField="Producto.PrecioVenta" HeaderText="Precio" DataFormatString="{0:c}"/>     
            <asp:TemplateField HeaderText="Cantidad">   
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total">          
                <ItemTemplate>
                    <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) *  Convert.ToDouble(Item.Producto.PrecioVenta)))%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server" Text=""  ></asp:CheckBox>
                  
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <p></p>

         <tr>
      <td>
          <asp:Button ID="UpdateBtn" runat="server" Text="Actualizar" OnClick="UpdateBtn_Click"/>
          </td>
      <td>
          <br />
    </td>
    </tr>
        <strong>
      
            <asp:Label  ID="LabelTotalText" runat="server" Text="Sub Total:"  ></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false" ></asp:Label>
             <br />
            <asp:Label ID="txtIgv" runat="server" Text="Igv:"></asp:Label>
            <asp:Label ID="IGV" runat="server" EnableViewState="false"></asp:Label>
              <br />
            <asp:Label ID="txtPagoTotal" runat="server" Text="Total:"></asp:Label>
            <asp:Label ID="PagoTotal" runat="server" EnableViewState="false"></asp:Label>
         </strong> 
    </div>
     <br />
    <table> 
        
    </table>
    <asp:Button ID="btnPedido" runat="server" Text="Button"  OnClick="btnPedido_Click" />

</asp:Content>
