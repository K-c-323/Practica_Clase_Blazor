using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Producto
    {
        [Required(ErrorMessage = "El campo codigo es Obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre es Obligatorio")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo Rol es Obligatorio")]
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public byte[] Imagen { get; set; }

    }
}
