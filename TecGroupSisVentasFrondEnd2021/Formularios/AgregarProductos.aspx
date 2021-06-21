<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="AgregarProductos.aspx.cs" Inherits="TecGroupSisVentasFrondEnd2021.Formularios.AgregarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
              <li class="breadcrumb-item"><a href="/Formularios/MantenimientoProducto.aspx">Listar</a></li>
            <li class="breadcrumb-item"><a href="/Formularios/AgregarProductos.aspx">Agregar</a></li>
        </ol>
    </nav>

    <br />
    <asp:DropDownList ID="ddlProductos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProductos_SelectedIndexChanged" CssClass="form-control"  ></asp:DropDownList>
       <br />




    <section class="content">


        <div class="container-fluid">
            <div class="row">

                <div class="col-md-6">

                    <div class="card card-primary">
                        <br />
                        <div class="card-header">
                            <h3 class="card-title">PRODUCTO</h3>
                        </div>


                        <div class="card-body">

                            <div class="form-group">
                                <label for="exampleInputEmail1">Nombre Producto</label>
                                <asp:TextBox ID="txtNombre" runat="server"   type="text" class="form-control" required="" ></asp:TextBox>                             
                            </div>

                            <div class="form-group">
                               <label for="exampleInputEmail1">Descripción Producto</label>
                            
                                <textarea id="txtDescProducto"   runat="server"  class="form-control" rows="3" required=""></textarea>
                                </div>

                           <div class="form-group">
                                <label for="exampleInputEmail1">Precio Compra</label>
                                <asp:TextBox ID="txtPrecioCompra" runat="server"   type="number" class="form-control" required="" ></asp:TextBox>                             
                            </div>
                         
                          <div class="form-group">
                                <label for="exampleInputEmail1">Precio Venta</label>
                                <asp:TextBox ID="txtPrecioVenta" runat="server"   type="number" class="form-control" required="" ></asp:TextBox>                             
                            </div>

                              
                          <div class="form-group">
                                <label for="exampleInputEmail1">Stock</label>
                                <asp:TextBox ID="txtStock" runat="server"   type="number" class="form-control" required="" ></asp:TextBox>                             
                            </div>
                                
                          <div class="form-group">
                                <label for="exampleInputEmail1">Foto</label>
                                <asp:TextBox ID="txtFoto" runat="server"   type="file" class="form-control" required="" ></asp:TextBox>                             
                            </div>
                                          
           
                        <div class="card-footer"  >                                  
                            <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR" OnClick="btnRegistrar_Click" />
                        </div>

                             <div class="card-footer"  >                                  
                            
                                 <asp:Button ID="btnModificar" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click" CssClass="btn btn-warning" Visible="false" />
                        </div>


              <div class="alert alert-success" runat="server" role ="alert" id="msg" visible="false">  registro correcto </div>

                <asp:Label ID="referId" runat="server" Text="" Visible="false"></asp:Label>

                 </div>
                    </div>
                </div>
                     </div>
                 </div>
      
     
    </section>

</asp:Content>
