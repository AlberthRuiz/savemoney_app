using System.ComponentModel.DataAnnotations;

namespace AppSaveMoney.Models {
    public class Transaccion {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        public int CategoriaId { get; set; }

        // Relaciones
        public virtual Categoria Categoria { get; set; }
    }
}
