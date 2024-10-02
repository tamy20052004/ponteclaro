using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Competencias
    {
        [Key]
        public int CompetenciaID { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
        
    }
}
