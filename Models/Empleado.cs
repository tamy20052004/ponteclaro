using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoID { get; set; }

        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaIngreso { get; set; }

        [StringLength(100)]
        public string Departamento { get; set; }

        [StringLength(100)]
        public string Puesto { get; set; }

        public decimal? SalarioMensual { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
    }
}
