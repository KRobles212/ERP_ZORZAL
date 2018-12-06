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
    
    public partial class tbSolicitudCredito
    {
        public int cred_Id { get; set; }
        public int clte_Id { get; set; }
        public byte escre_Id { get; set; }
        public System.DateTime cred_FechaSolicitud { get; set; }
        public System.DateTime cred_FechaAprobacion { get; set; }
        public decimal cred_MontoSolicitado { get; set; }
        public decimal cred_MontoAprobado { get; set; }
        public int cred_DiasSolicitado { get; set; }
        public int cred_DiasAprobado { get; set; }
        public int cred_UsuarioCrea { get; set; }
        public System.DateTime cred_FechaCrea { get; set; }
        public Nullable<int> cred_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cred_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEstadoSolicitudCredito tbEstadoSolicitudCredito { get; set; }
        public virtual tbCliente tbCliente { get; set; }
    }
}
