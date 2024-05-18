using System.ComponentModel.DataAnnotations;

namespace SistemaCITI_ORURO.Models
{
    public class Ingeniero
    {
        [Key]
        public int Id { get; set; }
        public int Rni { get; set; }
        public string? Ci { get; set; }
        public string? nombre { get; set; }
        public string? Especialidad { get; set; }
        public DateOnly FechaRegistro { get; set; }

        //un ingeniro realizaa muchos pagos
        // 1 ----- *
        public virtual List<Pago>? Pagos { get; set; }
    }
}
