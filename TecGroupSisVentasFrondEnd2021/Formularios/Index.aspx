<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.Index" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <asp:DataList ID="DataList2" runat="server"></asp:DataList>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="IdProducto" RepeatColumns="3" OnItemCommand="DataList1_ItemCommand"  CssClass="table table-responsive">

                     <ItemTemplate>
               

                                    <asp:Image ID="Image1" width="140" height="120" runat="server" ImageUrl='<%# "~/Imagenes/"+Eval("imagen") %>' CssClass="img-fluid" />
                                    <br />
                                    <br />
                                   Producto :
                                    <asp:Label ID="desproductoLabel" runat="server" Text='<%# Eval("desproducto") %>' />
                                    <br />
                                
                                    
                          
                          </ItemTemplate>


    </asp:DataList>


</body>
</html>
