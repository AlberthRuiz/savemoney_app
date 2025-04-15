using System.ComponentModel.DataAnnotations;

namespace AppSaveMoney.EntityLayer {
    public class Usuario {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo {0} es obligatorio")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]

        public string Apellido { get; set; }
        public bool Activo { get; set; } = true;

        // Relaciones (opcional, si se desea asociar todos los datos a un usuario)
        public virtual ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
        public virtual ICollection<Transaccion> Transacciones { get; set; } = new List<Transaccion>();
        public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
    }
}
