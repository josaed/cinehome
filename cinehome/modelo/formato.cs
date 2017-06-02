using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace cinehome.modelo
{
    public class formato
    {
        [Key]
        public int id_formato { get; set; }
        [Required(ErrorMessage = "Ingrese la descripción del formato")]
        [Display(Name = "formato")]
        public string descripcion_formato { get; set; }
       
    }
}