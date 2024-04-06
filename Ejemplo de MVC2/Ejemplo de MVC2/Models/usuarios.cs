using System.ComponentModel.DataAnnotations;

namespace Ejemplo_de_MVC2.Models
{
    public class usuarios
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string contra { get; set; }
        public string genero { get; set; }
        public string direccion { get; set; }
        public string pasatiempos { get; set; }
        public string cursos { get; set; }
        public string conocimientos { get; set; }
      

    }
}
