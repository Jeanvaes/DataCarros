using System.ComponentModel.DataAnnotations;
namespace DataCarros.Datos.Modelo
{
    public class Garaje
    {
        [Key]
        public int serial { get; set; }
        public string marca { get; set; }
        public int precio { get; set; }
        public string tipo { get; set; }
        public int power { get; set; }
    }
}
