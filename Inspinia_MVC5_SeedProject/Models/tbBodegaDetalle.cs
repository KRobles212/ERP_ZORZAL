//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_ZORZAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbBodegaDetalle
    {
        public int bodd_Id { get; set; }
        public string prod_Codigo { get; set; }
        public int bod_Id { get; set; }
        public decimal bodd_CantidadMinima { get; set; }
        public decimal bodd_CantidadMaxima { get; set; }
        public decimal bodd_PuntoReorden { get; set; }
        public int bodd_UsuarioCrea { get; set; }
        public System.DateTime bodd_FechaCrea { get; set; }
        public Nullable<int> bodd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> bodd_FechaModifica { get; set; }
        public decimal bodd_Costo { get; set; }
        public decimal bodd_CostoPromedio { get; set; }
    
        public virtual tbBodega tbBodega { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
