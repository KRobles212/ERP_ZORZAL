﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ZORZAL.Models
{
    [MetadataType(typeof(FacturaDetalleMetaData))]

    public partial class tbFacturaDetalle
    {
       
    }

    public class FacturaDetalleMetaData
    {
        public long fact_Id { get; set; }
        public short factd_Id { get; set; }
        [Display(Name = "Descripcion Producto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo {0} requerido")]
        public string prod_Codigo { get; set; }
        [Display(Name = "Cantidad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo {0} requerido")]
        public decimal factd_Cantidad { get; set; }
        [Display(Name = "Monto Descuento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo {0} requerido")]
        public decimal factd__MontoDescuento { get; set; }
        [Display(Name = "Porcentaje Descuento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo {0} requerido")]
        public decimal factd_PorcentajeDescuento { get; set; }
        [Display(Name = "Impuesto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo {0} requerido")]
        public decimal factd_Impuesto { get; set; }
        public int factd_UsuarioCrea { get; set; }
        public System.DateTime factd_FechaCrea { get; set; }
        public Nullable<int> factd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> factd_FechaModifica { get; set; }
    }
}