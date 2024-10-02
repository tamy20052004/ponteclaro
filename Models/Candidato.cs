using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Candidato
    {
        [Key]
        public int CandidatoID { get; set; }

        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string PuestoAspira { get; set; }

        [StringLength(100)]
        public string Departamento { get; set; }

        public decimal? SalarioAspira { get; set; }

        [StringLength(255)]
        public string PrincipalesCompetencias { get; set; }

        [StringLength(255)]
        public string PrincipalesCapacitaciones { get; set; }

        [StringLength(255)]
        public string ExperienciaLaboral { get; set; }

        [StringLength(255)]
        public string RecomendadoPor { get; set; }
    }
}
