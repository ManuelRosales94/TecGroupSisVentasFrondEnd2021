﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecGroupSisVentasFrondEnd2021.ServicioPedidos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PedidoCabecera", Namespace="http://schemas.datacontract.org/2004/07/TecGroup.Dominio.Entidades")]
    [System.SerializableAttribute()]
    public partial class PedidoCabecera : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> DescuentosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoPedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaPedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> IGVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdCuponField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPedidoCabField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> MonEnvioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> SubTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> SubTotal2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoPagoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoPedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> TotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> TotalmasEnvioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoDetalle[] detalleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Descuentos {
            get {
                return this.DescuentosField;
            }
            set {
                if ((this.DescuentosField.Equals(value) != true)) {
                    this.DescuentosField = value;
                    this.RaisePropertyChanged("Descuentos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoPedido {
            get {
                return this.EstadoPedidoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoPedidoField, value) != true)) {
                    this.EstadoPedidoField = value;
                    this.RaisePropertyChanged("EstadoPedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaPedido {
            get {
                return this.FechaPedidoField;
            }
            set {
                if ((this.FechaPedidoField.Equals(value) != true)) {
                    this.FechaPedidoField = value;
                    this.RaisePropertyChanged("FechaPedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> IGV {
            get {
                return this.IGVField;
            }
            set {
                if ((this.IGVField.Equals(value) != true)) {
                    this.IGVField = value;
                    this.RaisePropertyChanged("IGV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdCupon {
            get {
                return this.IdCuponField;
            }
            set {
                if ((this.IdCuponField.Equals(value) != true)) {
                    this.IdCuponField = value;
                    this.RaisePropertyChanged("IdCupon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPedidoCab {
            get {
                return this.IdPedidoCabField;
            }
            set {
                if ((this.IdPedidoCabField.Equals(value) != true)) {
                    this.IdPedidoCabField = value;
                    this.RaisePropertyChanged("IdPedidoCab");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> MonEnvio {
            get {
                return this.MonEnvioField;
            }
            set {
                if ((this.MonEnvioField.Equals(value) != true)) {
                    this.MonEnvioField = value;
                    this.RaisePropertyChanged("MonEnvio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCli {
            get {
                return this.NombreCliField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCliField, value) != true)) {
                    this.NombreCliField = value;
                    this.RaisePropertyChanged("NombreCli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> SubTotal {
            get {
                return this.SubTotalField;
            }
            set {
                if ((this.SubTotalField.Equals(value) != true)) {
                    this.SubTotalField = value;
                    this.RaisePropertyChanged("SubTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> SubTotal2 {
            get {
                return this.SubTotal2Field;
            }
            set {
                if ((this.SubTotal2Field.Equals(value) != true)) {
                    this.SubTotal2Field = value;
                    this.RaisePropertyChanged("SubTotal2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoPago {
            get {
                return this.TipoPagoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoPagoField, value) != true)) {
                    this.TipoPagoField = value;
                    this.RaisePropertyChanged("TipoPago");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoPedido {
            get {
                return this.TipoPedidoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoPedidoField, value) != true)) {
                    this.TipoPedidoField = value;
                    this.RaisePropertyChanged("TipoPedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> TotalmasEnvio {
            get {
                return this.TotalmasEnvioField;
            }
            set {
                if ((this.TotalmasEnvioField.Equals(value) != true)) {
                    this.TotalmasEnvioField = value;
                    this.RaisePropertyChanged("TotalmasEnvio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoDetalle[] detalle {
            get {
                return this.detalleField;
            }
            set {
                if ((object.ReferenceEquals(this.detalleField, value) != true)) {
                    this.detalleField = value;
                    this.RaisePropertyChanged("detalle");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PedidoDetalle", Namespace="http://schemas.datacontract.org/2004/07/TecGroup.Dominio.Entidades")]
    [System.SerializableAttribute()]
    public partial class PedidoDetalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaRegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdCuponField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPedidoCabField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPedidoDetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreProdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PrecioDescuentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PrecioUnidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> TotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaRegistro {
            get {
                return this.FechaRegistroField;
            }
            set {
                if ((this.FechaRegistroField.Equals(value) != true)) {
                    this.FechaRegistroField = value;
                    this.RaisePropertyChanged("FechaRegistro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdCupon {
            get {
                return this.IdCuponField;
            }
            set {
                if ((this.IdCuponField.Equals(value) != true)) {
                    this.IdCuponField = value;
                    this.RaisePropertyChanged("IdCupon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPedidoCab {
            get {
                return this.IdPedidoCabField;
            }
            set {
                if ((this.IdPedidoCabField.Equals(value) != true)) {
                    this.IdPedidoCabField = value;
                    this.RaisePropertyChanged("IdPedidoCab");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPedidoDet {
            get {
                return this.IdPedidoDetField;
            }
            set {
                if ((this.IdPedidoDetField.Equals(value) != true)) {
                    this.IdPedidoDetField = value;
                    this.RaisePropertyChanged("IdPedidoDet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProducto {
            get {
                return this.IdProductoField;
            }
            set {
                if ((this.IdProductoField.Equals(value) != true)) {
                    this.IdProductoField = value;
                    this.RaisePropertyChanged("IdProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProd {
            get {
                return this.NombreProdField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreProdField, value) != true)) {
                    this.NombreProdField = value;
                    this.RaisePropertyChanged("NombreProd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PrecioDescuento {
            get {
                return this.PrecioDescuentoField;
            }
            set {
                if ((this.PrecioDescuentoField.Equals(value) != true)) {
                    this.PrecioDescuentoField = value;
                    this.RaisePropertyChanged("PrecioDescuento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PrecioUnidad {
            get {
                return this.PrecioUnidadField;
            }
            set {
                if ((this.PrecioUnidadField.Equals(value) != true)) {
                    this.PrecioUnidadField = value;
                    this.RaisePropertyChanged("PrecioUnidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioPedidos.IPedidoRestServicio")]
    public interface IPedidoRestServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/ObtenerporId", ReplyAction="http://tempuri.org/IPedidoRestServicio/ObtenerporIdResponse")]
        TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera ObtenerporId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/ObtenerporId", ReplyAction="http://tempuri.org/IPedidoRestServicio/ObtenerporIdResponse")]
        System.Threading.Tasks.Task<TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera> ObtenerporIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/Listado", ReplyAction="http://tempuri.org/IPedidoRestServicio/ListadoResponse")]
        TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[] Listado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/Listado", ReplyAction="http://tempuri.org/IPedidoRestServicio/ListadoResponse")]
        System.Threading.Tasks.Task<TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[]> ListadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/ListadoPorCliente", ReplyAction="http://tempuri.org/IPedidoRestServicio/ListadoPorClienteResponse")]
        TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[] ListadoPorCliente(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/ListadoPorCliente", ReplyAction="http://tempuri.org/IPedidoRestServicio/ListadoPorClienteResponse")]
        System.Threading.Tasks.Task<TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[]> ListadoPorClienteAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/Insertar", ReplyAction="http://tempuri.org/IPedidoRestServicio/InsertarResponse")]
        int Insertar(TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/Insertar", ReplyAction="http://tempuri.org/IPedidoRestServicio/InsertarResponse")]
        System.Threading.Tasks.Task<int> InsertarAsync(TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera pedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/Anular", ReplyAction="http://tempuri.org/IPedidoRestServicio/AnularResponse")]
        int Anular(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidoRestServicio/Anular", ReplyAction="http://tempuri.org/IPedidoRestServicio/AnularResponse")]
        System.Threading.Tasks.Task<int> AnularAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPedidoRestServicioChannel : TecGroupSisVentasFrondEnd2021.ServicioPedidos.IPedidoRestServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PedidoRestServicioClient : System.ServiceModel.ClientBase<TecGroupSisVentasFrondEnd2021.ServicioPedidos.IPedidoRestServicio>, TecGroupSisVentasFrondEnd2021.ServicioPedidos.IPedidoRestServicio {
        
        public PedidoRestServicioClient() {
        }
        
        public PedidoRestServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PedidoRestServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidoRestServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidoRestServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera ObtenerporId(string id) {
            return base.Channel.ObtenerporId(id);
        }
        
        public System.Threading.Tasks.Task<TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera> ObtenerporIdAsync(string id) {
            return base.Channel.ObtenerporIdAsync(id);
        }
        
        public TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[] Listado() {
            return base.Channel.Listado();
        }
        
        public System.Threading.Tasks.Task<TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[]> ListadoAsync() {
            return base.Channel.ListadoAsync();
        }
        
        public TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[] ListadoPorCliente(string id) {
            return base.Channel.ListadoPorCliente(id);
        }
        
        public System.Threading.Tasks.Task<TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera[]> ListadoPorClienteAsync(string id) {
            return base.Channel.ListadoPorClienteAsync(id);
        }
        
        public int Insertar(TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera pedido) {
            return base.Channel.Insertar(pedido);
        }
        
        public System.Threading.Tasks.Task<int> InsertarAsync(TecGroupSisVentasFrondEnd2021.ServicioPedidos.PedidoCabecera pedido) {
            return base.Channel.InsertarAsync(pedido);
        }
        
        public int Anular(string id) {
            return base.Channel.Anular(id);
        }
        
        public System.Threading.Tasks.Task<int> AnularAsync(string id) {
            return base.Channel.AnularAsync(id);
        }
    }
}