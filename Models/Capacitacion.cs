using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Capacitacion
    {
        [Key]
        public int CapacitacionID { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Nivel { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }

        [StringLength(255)]
        public string Institucion { get; set; }
    }
}
