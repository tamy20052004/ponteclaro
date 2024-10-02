using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class ExperienciaLaboral
    {
        [Key]
        public int ExperienciaID { get; set; }

        [Required]
        [StringLength(255)]
        public string Empresa { get; set; }

        [Required]
        [StringLength(100)]
        public string PuestoOcupado { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }

        public decimal? Salario { get; set; }
    }
}
