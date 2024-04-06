using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class tipo_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_tipo_equipo { get; set; }
        [Display(Name = "Su descripcion")]
        public String? descripcion { get; set; }
        [Display(Name = "Estado")]
        public String? estados { get; set; }


    }
}
