//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_ZORZAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEstadoMovimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEstadoMovimiento()
        {
            this.tbBodega = new HashSet<tbBodega>();
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbProductoSubcategoria = new HashSet<tbProductoSubcategoria>();
            this.tbSalida = new HashSet<tbSalida>();
        }
    
        public byte estm_Id { get; set; }
        public string estm_Descripcion { get; set; }
        public int estm_UsuarioCrea { get; set; }
        public System.DateTime estm_FechaCrea { get; set; }
        public Nullable<int> estm_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> estm_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodega> tbBodega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProductoSubcategoria> tbProductoSubcategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
    }
}
