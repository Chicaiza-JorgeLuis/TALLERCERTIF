//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUTaller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pelicula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Pelicula()
        {
          
        }
        [ScaffoldColumn(false)]

        public int id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El nombre es requerido"), MaxLength(55)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Display(Name = "Fecha lanzamineto")]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> fecha_lanzamiento { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La categoria es requerida"), MaxLength(55)]
        [Display(Name = "Categoria")]
        public string categoria { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La duracion es requerida")]
        [Display(Name = "Duracion")]
        public Nullable<int> duracion { get; set; }
    }
}
