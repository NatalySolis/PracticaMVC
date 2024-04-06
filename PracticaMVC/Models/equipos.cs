using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class equipos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_equipos { get; set; }
        [Display(Name = "nombre equipo")]
        public string nombre { get; set; }
        [Display(Name = "descripcion")]
        public string descripcion { get; set; }
        [Display(Name = "id tipo equipo")]
        public int? id_tipo_equipo { get; set; }
        [Display(Name = "id de marca")]
        public int? id_marca { get; set; }
        [Display(Name = "modelo")]
        public string modelo { get; set; }
        [Display(Name = "anio de compra")]
        public int? anio_compra { get; set; }
        [Display(Name = "costo")]
        public decimal costo { get; set; }
        [Display(Name = "vida")]
        public int? vida_util { get; set; }
        [Display(Name = "id estados")]
        public int? id_estados_equipo { get; set; }
        [Display(Name = "estado")]
        public string estado { get; set; }
        
    }
}
