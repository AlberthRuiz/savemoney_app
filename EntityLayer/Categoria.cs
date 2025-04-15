using System.ComponentModel.DataAnnotations;
namespace AppSaveMoney.EntityLayer;

public class Categoria {
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Campo {0} es obligatorio")]
    [MaxLength(50, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Campo {0} es obligatorio")]
    [MaxLength(50, ErrorMessage = "El campo {0} no puede exceder {0} caracteres")]
    public string? Descripcion { get; set; }
    public bool Activo { get; set; }
    public bool EsGasto { get; set; } 

   
    public virtual ICollection<Transaccion> Transacciones { get; set; } = new List<Transaccion>();
    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
}
