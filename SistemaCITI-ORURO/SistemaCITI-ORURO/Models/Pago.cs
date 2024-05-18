using System.ComponentModel.DataAnnotations;

namespace SistemaCITI_ORURO.Models
{
    public class Pago
    {
        [Key]
        public int Id { get; set; }
        public int NroRecibo { get; set; }
        public DateOnly Fecha { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public decimal Total { get; set; }


        //claves foraneas
        public int UsuarioId { get; set; }
        public int IngenieroId { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Ingeniero? Ingeniero { get; set;}
    }
}
