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
    
    public partial class tbMoneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbMoneda()
        {
            this.tbCuentasBanco = new HashSet<tbCuentasBanco>();
        }
    
        public int mnda_Id { get; set; }
        public string mnda_Iso { get; set; }
        public string mnda_Nombre { get; set; }
        public string mnda_UsuarioCrea { get; set; }
        public System.DateTime mnda_FechaCrea { get; set; }
        public string mnda_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> mnda_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCuentasBanco> tbCuentasBanco { get; set; }
    }
}