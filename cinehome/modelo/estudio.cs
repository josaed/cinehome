using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace cinehome.modelo
{
    public class estudio
    {
        [Key]
        public int id_estudio { get; set; }
        [Required(ErrorMessage = "Ingrese la descripción del estudio")]
        [Display(Name = "genero")]
        public string descripcion_estudio { get; set; }
        
    }
}