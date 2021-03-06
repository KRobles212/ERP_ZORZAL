﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ZORZAL.Models
{
    [MetadataType(typeof(ClientesMetaData))]

    public partial class tbCliente
    {

    }
    public class ClientesMetaData
    {
        [Display(Name = "Id Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int clte_Id { get; set; }
        [Display(Name = "RTN/Identificación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_RTN_Identidad_Pasaporte { get; set; }
        [Display(Name = "¿Es Persona Natural?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public bool clte_EsPersonaNatural { get; set; }
        [Display(Name = "Nombres")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Nombres { get; set; }
        [Display(Name = "Apellidos")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Apellidos { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime clte_FechaNacimiento { get; set; }
        [Display(Name = "Nacionalidad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Nacionalidad { get; set; }
        [Display(Name = "Sexo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Sexo { get; set; }
        [Display(Name = "Teléfono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Telefono { get; set; }
        [Display(Name = "Nombre Comercial")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_NombreComercial { get; set; }
        [Display(Name = "Razón Social")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_RazonSocial { get; set; }
        [Display(Name = "Contacto Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_ContactoNombre { get; set; }
        [Display(Name = "Contacto Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_ContactoEmail { get; set; }
        [Display(Name = "Contacto Teléfono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_ContactoTelefono { get; set; }
        [Display(Name = "Fecha Constitución")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> clte_FechaConstitucion { get; set; }
        [Display(Name = "Código Municipio")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string mun_Codigo { get; set; }
        [Display(Name = "Dirección")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Direccion { get; set; }
        [Display(Name = "Correo Electrónico")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_CorreoElectronico { get; set; }
        [Display(Name = "¿Es Activo?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_EsActivo { get; set; }
        [Display(Name = "Razón Inactivación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_RazonInactivo { get; set; }
        [Display(Name = "¿Con Crédito?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public bool clte_ConCredito { get; set; }
        [Display(Name = "¿Es Minorista?")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public bool clte_EsMinorista { get; set; }
        [Display(Name = "Observaciones")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string clte_Observaciones_ { get; set; }
        [Display(Name = "Usuario Crea")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int clte_UsuarioCrea { get; set; }
        [Display(Name = "Fecha Crea")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public System.DateTime clte_FechaCrea { get; set; }
        [Display(Name = "Usuario Modificó")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public Nullable<int> clte_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modificó")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public Nullable<System.DateTime> clte_FechaModifica { get; set; }

    }
}