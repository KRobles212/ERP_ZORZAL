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
    
    public partial class tbCaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCaja()
        {
            this.tbSalida = new HashSet<tbSalida>();
        }
    
        public int cja_Id { get; set; }
        public string cja_Descripcion { get; set; }
        public int cja_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> cja_FechaCrea { get; set; }
        public int cja_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cja_FechaModifica { get; set; }
        public int sald_Id { get; set; }
    
        public virtual tbSalidaDetalle tbSalidaDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
    }
}
