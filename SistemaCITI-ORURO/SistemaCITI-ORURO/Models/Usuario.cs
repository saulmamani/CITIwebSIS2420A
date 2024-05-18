using SistemaCITI_ORURO.Dtos;
using System.ComponentModel.DataAnnotations;

namespace SistemaCITI_ORURO.Models
{
    public class Usuario
    {
        [Key]  //Annotations
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public RolEnum? Rol { get; set; }

        //un usuario registra muchos pagos
        // 1 ----- *
        public virtual List<Pago>? Pagos { get; set; }
    }
}
