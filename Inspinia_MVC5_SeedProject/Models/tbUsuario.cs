//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUsuario()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
            this.tbObjeto = new HashSet<tbObjeto>();
            this.tbRol = new HashSet<tbRol>();
            this.tbRolesUsuario = new HashSet<tbRolesUsuario>();
            this.tbRolesUsuario1 = new HashSet<tbRolesUsuario>();
            this.tbActividadEconomica = new HashSet<tbActividadEconomica>();
            this.tbActividadEconomica1 = new HashSet<tbActividadEconomica>();
            this.tbCaja = new HashSet<tbCaja>();
            this.tbCaja1 = new HashSet<tbCaja>();
            this.tbCuponDescuento = new HashSet<tbCuponDescuento>();
            this.tbCuponDescuento1 = new HashSet<tbCuponDescuento>();
            this.tbDenominacion = new HashSet<tbDenominacion>();
            this.tbDenominacion1 = new HashSet<tbDenominacion>();
            this.tbDenominacionArqueo = new HashSet<tbDenominacionArqueo>();
            this.tbDenominacionArqueo1 = new HashSet<tbDenominacionArqueo>();
            this.tbDevolucion = new HashSet<tbDevolucion>();
            this.tbDevolucion1 = new HashSet<tbDevolucion>();
            this.tbDevolucionDetalle = new HashSet<tbDevolucionDetalle>();
            this.tbDevolucionDetalle1 = new HashSet<tbDevolucionDetalle>();
            this.tbDocumentoFiscal = new HashSet<tbDocumentoFiscal>();
            this.tbDocumentoFiscal1 = new HashSet<tbDocumentoFiscal>();
            this.tbEstadoSolicitudCredito = new HashSet<tbEstadoSolicitudCredito>();
            this.tbEstadoSolicitudCredito1 = new HashSet<tbEstadoSolicitudCredito>();
            this.tbExoneracion = new HashSet<tbExoneracion>();
            this.tbExoneracion1 = new HashSet<tbExoneracion>();
            this.tbListadoPrecioDetalle = new HashSet<tbListadoPrecioDetalle>();
            this.tbListadoPrecioDetalle1 = new HashSet<tbListadoPrecioDetalle>();
            this.tbListaPrecio = new HashSet<tbListaPrecio>();
            this.tbListaPrecio1 = new HashSet<tbListaPrecio>();
            this.tbMoneda = new HashSet<tbMoneda>();
            this.tbMoneda1 = new HashSet<tbMoneda>();
            this.tbMovimientoCaja = new HashSet<tbMovimientoCaja>();
            this.tbMovimientoCaja1 = new HashSet<tbMovimientoCaja>();
            this.tbNotaCredito = new HashSet<tbNotaCredito>();
            this.tbNotaCredito1 = new HashSet<tbNotaCredito>();
            this.tbPago = new HashSet<tbPago>();
            this.tbPago1 = new HashSet<tbPago>();
            this.tbTipoPago = new HashSet<tbTipoPago>();
            this.tbTipoPago1 = new HashSet<tbTipoPago>();
            this.tbPedido = new HashSet<tbPedido>();
            this.tbPedido1 = new HashSet<tbPedido>();
            this.tbPedidoDetalle = new HashSet<tbPedidoDetalle>();
            this.tbPedidoDetalle1 = new HashSet<tbPedidoDetalle>();
            this.tbSolicitudCredito = new HashSet<tbSolicitudCredito>();
            this.tbSolicitudCredito1 = new HashSet<tbSolicitudCredito>();
            this.tbSolicitudEfectivo = new HashSet<tbSolicitudEfectivo>();
            this.tbSolicitudEfectivo1 = new HashSet<tbSolicitudEfectivo>();
            this.tbSolicitudEfectivo2 = new HashSet<tbSolicitudEfectivo>();
            this.tbSolicitudEfectivoDetalle = new HashSet<tbSolicitudEfectivoDetalle>();
            this.tbSolicitudEfectivoDetalle1 = new HashSet<tbSolicitudEfectivoDetalle>();
            this.tbSucursal = new HashSet<tbSucursal>();
            this.tbSucursal1 = new HashSet<tbSucursal>();
            this.tbTipoIdentificacion = new HashSet<tbTipoIdentificacion>();
            this.tbTipoIdentificacion1 = new HashSet<tbTipoIdentificacion>();
            this.tbBanco = new HashSet<tbBanco>();
            this.tbBanco1 = new HashSet<tbBanco>();
            this.tbCuentasBanco = new HashSet<tbCuentasBanco>();
            this.tbCuentasBanco1 = new HashSet<tbCuentasBanco>();
            this.tbDepartamento = new HashSet<tbDepartamento>();
            this.tbMunicipio = new HashSet<tbMunicipio>();
            this.tbParametro = new HashSet<tbParametro>();
            this.tbUnidadMedida = new HashSet<tbUnidadMedida>();
            this.tbUnidadMedida1 = new HashSet<tbUnidadMedida>();
            this.tbUnidadMedida2 = new HashSet<tbUnidadMedida>();
            this.tbBodega = new HashSet<tbBodega>();
            this.tbBodega1 = new HashSet<tbBodega>();
            this.tbBox = new HashSet<tbBox>();
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbEstadoMovimiento = new HashSet<tbEstadoMovimiento>();
            this.tbInventarioFisico = new HashSet<tbInventarioFisico>();
            this.tbInventarioFisicoDetalle = new HashSet<tbInventarioFisicoDetalle>();
            this.tbProducto = new HashSet<tbProducto>();
            this.tbProducto1 = new HashSet<tbProducto>();
            this.tbProductoCategoria = new HashSet<tbProductoCategoria>();
            this.tbProductoCategoria1 = new HashSet<tbProductoCategoria>();
            this.tbProductoSubcategoria = new HashSet<tbProductoSubcategoria>();
            this.tbProductoSubcategoria1 = new HashSet<tbProductoSubcategoria>();
            this.tbProveedor = new HashSet<tbProveedor>();
            this.tbSalida = new HashSet<tbSalida>();
            this.tbSalida1 = new HashSet<tbSalida>();
            this.tbSalidaDetalle = new HashSet<tbSalidaDetalle>();
            this.tbTipoEntrada = new HashSet<tbTipoEntrada>();
            this.tbTipoSalida = new HashSet<tbTipoSalida>();
            this.tbCliente = new HashSet<tbCliente>();
            this.tbCliente1 = new HashSet<tbCliente>();
            this.tbFactura = new HashSet<tbFactura>();
            this.tbFactura1 = new HashSet<tbFactura>();
            this.tbPuntoEmision = new HashSet<tbPuntoEmision>();
            this.tbPuntoEmision1 = new HashSet<tbPuntoEmision>();
            this.tbPuntoEmisionDetalle = new HashSet<tbPuntoEmisionDetalle>();
            this.tbPuntoEmisionDetalle1 = new HashSet<tbPuntoEmisionDetalle>();
            this.tbAccesoRol1 = new HashSet<tbAccesoRol>();
            this.tbObjeto1 = new HashSet<tbObjeto>();
            this.tbRol1 = new HashSet<tbRol>();
            this.tbDepartamento1 = new HashSet<tbDepartamento>();
            this.tbEmpleado = new HashSet<tbEmpleado>();
            this.tbMunicipio1 = new HashSet<tbMunicipio>();
            this.tbParametro1 = new HashSet<tbParametro>();
            this.tbEntrada1 = new HashSet<tbEntrada>();
            this.tbEstadoMovimiento1 = new HashSet<tbEstadoMovimiento>();
            this.tbInventarioFisico1 = new HashSet<tbInventarioFisico>();
            this.tbInventarioFisicoDetalle1 = new HashSet<tbInventarioFisicoDetalle>();
            this.tbProveedor1 = new HashSet<tbProveedor>();
            this.tbTipoEntrada1 = new HashSet<tbTipoEntrada>();
            this.tbBodegaDetalle = new HashSet<tbBodegaDetalle>();
            this.tbBodegaDetalle1 = new HashSet<tbBodegaDetalle>();
            this.tbEmpleado1 = new HashSet<tbEmpleado>();
            this.tbTipoSalida1 = new HashSet<tbTipoSalida>();
        }
    
        public int usu_Id { get; set; }
        public string usu_NombreUsuario { get; set; }
        public byte[] usu_Password { get; set; }
        public string usu_Nombres { get; set; }
        public string usu_Apellidos { get; set; }
        public string usu_Correo { get; set; }
        public bool usu_EsActivo { get; set; }
        public string usu_RazonInactivo { get; set; }
        public bool usu_EsAdministrador { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbObjeto> tbObjeto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRol> tbRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbActividadEconomica> tbActividadEconomica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbActividadEconomica> tbActividadEconomica1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCaja> tbCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCaja> tbCaja1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCuponDescuento> tbCuponDescuento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCuponDescuento> tbCuponDescuento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDenominacion> tbDenominacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDenominacion> tbDenominacion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDenominacionArqueo> tbDenominacionArqueo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDenominacionArqueo> tbDenominacionArqueo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucion> tbDevolucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucion> tbDevolucion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucionDetalle> tbDevolucionDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucionDetalle> tbDevolucionDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDocumentoFiscal> tbDocumentoFiscal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDocumentoFiscal> tbDocumentoFiscal1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEstadoSolicitudCredito> tbEstadoSolicitudCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEstadoSolicitudCredito> tbEstadoSolicitudCredito1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbExoneracion> tbExoneracion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbExoneracion> tbExoneracion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbListadoPrecioDetalle> tbListadoPrecioDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbListadoPrecioDetalle> tbListadoPrecioDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbListaPrecio> tbListaPrecio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbListaPrecio> tbListaPrecio1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMoneda> tbMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMoneda> tbMoneda1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMovimientoCaja> tbMovimientoCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMovimientoCaja> tbMovimientoCaja1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbNotaCredito> tbNotaCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbNotaCredito> tbNotaCredito1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPago> tbPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPago> tbPago1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPago> tbTipoPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoPago> tbTipoPago1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedido> tbPedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedido> tbPedido1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedidoDetalle> tbPedidoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedidoDetalle> tbPedidoDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudCredito> tbSolicitudCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudCredito> tbSolicitudCredito1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivo> tbSolicitudEfectivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivo> tbSolicitudEfectivo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivo> tbSolicitudEfectivo2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivoDetalle> tbSolicitudEfectivoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivoDetalle> tbSolicitudEfectivoDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSucursal> tbSucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSucursal> tbSucursal1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoIdentificacion> tbTipoIdentificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoIdentificacion> tbTipoIdentificacion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBanco> tbBanco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBanco> tbBanco1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCuentasBanco> tbCuentasBanco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCuentasBanco> tbCuentasBanco1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamento> tbDepartamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipio> tbMunicipio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUnidadMedida> tbUnidadMedida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUnidadMedida> tbUnidadMedida1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUnidadMedida> tbUnidadMedida2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodega> tbBodega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodega> tbBodega1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBox> tbBox { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEstadoMovimiento> tbEstadoMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisico> tbInventarioFisico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisicoDetalle> tbInventarioFisicoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoCategoria> tbProductoCategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoCategoria> tbProductoCategoria1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoSubcategoria> tbProductoSubcategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoSubcategoria> tbProductoSubcategoria1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProveedor> tbProveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalidaDetalle> tbSalidaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoEntrada> tbTipoEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoSalida> tbTipoSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCliente> tbCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCliente> tbCliente1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFactura> tbFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFactura> tbFactura1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPuntoEmision> tbPuntoEmision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPuntoEmision> tbPuntoEmision1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPuntoEmisionDetalle> tbPuntoEmisionDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPuntoEmisionDetalle> tbPuntoEmisionDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbObjeto> tbObjeto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRol> tbRol1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamento> tbDepartamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleado> tbEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipio> tbMunicipio1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEstadoMovimiento> tbEstadoMovimiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisico> tbInventarioFisico1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbInventarioFisicoDetalle> tbInventarioFisicoDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProveedor> tbProveedor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoEntrada> tbTipoEntrada1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodegaDetalle> tbBodegaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodegaDetalle> tbBodegaDetalle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleado> tbEmpleado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoSalida> tbTipoSalida1 { get; set; }
    }
}
