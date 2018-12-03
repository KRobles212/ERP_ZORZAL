﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ZORZAL.Models
{
    [MetadataType(typeof(MonedasMetaData))]

    public partial class tbMoneda
    {
    }


    public class MonedasMetaData
    {
        [Display (Name ="Id Modena")]
        [Required]
        public short mnda_Id { get; set; }
        [Display(Name = "Abreviatura")]
        [Required]
        public string mnda_Abreviatura { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string mnda_Nombre { get; set; }
        [Display(Name = "Usuario Crea")]
        [Required]
        public int mnda_UsuarioCrea { get; set; }
        [Display(Name = "Fecha Crea")]
        [Required]
        public System.DateTime mnda_FechaCrea { get; set; }
        [Display(Name = "Usuario Modifica")]
        [Required]
        public Nullable<int> mnda_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modifica")]
        [Required]
        public Nullable<System.DateTime> mnda_FechaModifica { get; set; }
    }
}