using System.ComponentModel.DataAnnotations;

namespace APIpractico.Models
{
    public enum StatusType {
        Activo,
        Inactivo
    }
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        [Required]
        public StatusType Status {get; set;}
    }
}