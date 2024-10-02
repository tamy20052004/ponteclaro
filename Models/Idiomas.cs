using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Idiomas
    {
        [Key]
        public int IdiomaID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
        
    }
}
