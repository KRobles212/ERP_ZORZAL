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
    
    public partial class Hijos
    {
        public int CodPadre { get; set; }
        public int CodHijo { get; set; }
        public string NombresHijo { get; set; }
        public string ApellidosHijo { get; set; }
        public System.DateTime FechaCreo { get; set; }
        public int UsuarioCreo { get; set; }
        public Nullable<System.DateTime> FechaModifico { get; set; }
        public Nullable<int> UsuarioModifico { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual Padres Padres { get; set; }
    }
}
