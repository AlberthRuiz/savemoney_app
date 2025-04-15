using System.ComponentModel.DataAnnotations;

namespace AppSaveMoney.Models {
    public class Presupuesto {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }

        // Relaciones
        public virtual Categoria Categoria { get; set; }
    }
}
