using System.ComponentModel.DataAnnotations;

namespace TSNP084024__UNIDAD3.Models
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Sinopsis { get; set; }
        public int Duracion { get; set; }
        public string? Clasificacion { get; set; }


    }
}
