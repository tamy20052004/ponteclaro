using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Puesto
    {
        [Key]
        public int PuestoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string NivelRiesgo { get; set; }

        public decimal NivelMinimoSalario { get; set; }

        public decimal NivelMaximoSalario { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
    }
}
