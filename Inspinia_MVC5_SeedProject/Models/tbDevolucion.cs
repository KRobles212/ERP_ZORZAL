//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDevolucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDevolucion()
        {
            this.tbNotaCredito = new HashSet<tbNotaCredito>();
        }
    
        public string dev_Id { get; set; }
        public string fact_Codigo { get; set; }
        public System.DateTime dev_Fecha { get; set; }
        public int clte_id { get; set; }
        public string dev_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> dev_FechaCrea { get; set; }
        public string dev_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> dev_FechaModifica { get; set; }
    
        public virtual tbCliente tbCliente { get; set; }
        public virtual tbFactura tbFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbNotaCredito> tbNotaCredito { get; set; }
    }
}
